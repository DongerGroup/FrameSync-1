﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using Framework;
using GameData;

namespace Game
{
    public enum GameVersionMode
    {
        Release,    //正常模式
        Debug       //测试模式
    }

    public enum GameNetMode
    {
        Network,    //联网
        StandAlone, //单机
    }
    public class GameStarter  : MonoBehaviour
    {
        public GameVersionMode versionMode = GameVersionMode.Debug;
        public GameNetMode netMode = GameNetMode.StandAlone;
        public static StateContainerBase GameGlobalState { get; private set; }
        void Start()
        {
            InitSingleton();
            LoadConfigs();
        }

        private int m_nConfingIndex;
        private void LoadConfigs()
        {
            m_nConfingIndex = 5;
            ResCfgSys.Instance.LoadResCfgs("Config/Data", OnLoadOneConfig);
            SkillCfgSys.Instance.LoadResCfgs(OnLoadOneConfig);
            RemoteCfgSys.Instance.LoadResCfgs(OnLoadOneConfig);
            HangPointCfgSys.Instance.LoadResCfgs(OnLoadOneConfig);
            GameColliderCfgSys.Instance.LoadResCfgs(OnLoadOneConfig);
        }

        private void OnLoadOneConfig()
        {
            m_nConfingIndex--;
            if(m_nConfingIndex==0)
            {
                OnLoadConfigs();
            }
        }

        private void OnLoadConfigs()
        {
            InitUI();
            InitState();
        }

        private void InitState()
        {
            var stateData = GameStateCfg.GetConfig(versionMode, netMode);
            if (stateData == null)
            {
                CLog.LogError("没找版本模式为:" + versionMode + ",网络模式为:" + netMode + "的状态配置");
                return;
            }
            GameGlobalState = (StateContainerBase)CreateState(stateData);
            GameGlobalState._OnEnter();
        }

        private void InitUI()
        {
            List<ResUI> lst = ResCfgSys.Instance.GetCfgLst<ResUI>();
            for (int i = 0; i < lst.Count; i++)
            {
                ViewSys.Instance.RegistUIPath(lst[i].name, lst[i].prefab);
            }
        }

        protected StateBase CreateState(GameStateData stateData)
        {
            StateBase state = Activator.CreateInstance(stateData.mClassType) as StateBase;
            if(stateData.mSubStateData != null)
            {
                StateContainerBase stateContainer = (StateContainerBase)state;
                for (int i = 0; i < stateData.mSubStateData.Length; i++)
                {
                    var data = stateData.mSubStateData[i];
                    StateBase subState = CreateState(data);
                    stateContainer.AddState((int)data.mStateType, subState, data.mDefaultState);
                }
            }
            return state;
        }

        //初始化所有单例
        protected void InitSingleton()
        {
            gameObject.AddComponentOnce<NetSys>();
            if (netMode == GameNetMode.Network)
            {
                NetSys.Instance.CreateChannel(NetChannelType.Game,NetChannelModeType.Tcp);
            }
            else if(netMode == GameNetMode.StandAlone)
            {
                NetSys.Instance.CreateChannel(NetChannelType.Game, NetChannelModeType.StandAlone);
                gameObject.AddComponentOnce<ClientServer>();
                ClientServer.Instance.StartServer();
            }
            gameObject.AddComponentOnce<FrameSyncSys>();
            gameObject.AddComponentOnce<ResourceSys>();
            ResourceSys.Instance.Init(true, "Assets/ResourceEx");
            gameObject.AddComponentOnce<UpdateScheduler>();
            gameObject.AddComponentOnce<TouchDispatcher>();
            //初始化对象池
            GameObject goPool = new GameObject();
            goPool.name = "GameObjectPool";
            GameObject.DontDestroyOnLoad(goPool);
            goPool.AddComponentOnce<GameObjectPool>();
            //初始化特效池
            GameObject sceneEffectPool = new GameObject();
            sceneEffectPool.name = "SceneEffectPool";
            GameObject.DontDestroyOnLoad(sceneEffectPool);
            sceneEffectPool.AddComponentOnce<SceneEffectPool>();

            GameObject uiEffectPool = new GameObject();
            uiEffectPool.name = "UIEffectPool";
            GameObject.DontDestroyOnLoad(uiEffectPool);
            uiEffectPool.AddComponentOnce<UIEffectPool>();

            GameObject uiGO = transform.Find("UIContainer").gameObject;
            uiGO.AddComponentOnce<ViewSys>();

            gameObject.AddComponentOnce<FPSMono>();
           
        }

        void Update()
        {
            if(GameGlobalState != null)
            {
                GameGlobalState._OnUpdate();
            }

            //if (Input.GetMouseButtonUp(0))
            //{
            //    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            //    RaycastHit hitInfo;
            //    if (Physics.Raycast(ray, out hitInfo))
            //    {
            //        if (null != PvpPlayerMgr.Instance.mainPlayer)
            //        {
            //            Unit unit = PvpPlayerMgr.Instance.mainPlayer.unit;
            //            if (null != unit)
            //            {
            //                //unit.ReqMove(TSVector.FromUnitVector3(hitInfo.point));
            //                var direction = TSVector.FromUnitVector3(hitInfo.point - unit.transform.position);
            //                direction.Normalize();
            //                CLog.LogColorArgs("#ff0000", direction);
            //                unit.ReqMoveForward(direction);
            //            }
            //        }
            //    }
            //}
        }

        void LateUpdate()
        {
            if (GameGlobalState != null)
            {
                GameGlobalState._OnLateUpdate();
            }
        }
    }
}
