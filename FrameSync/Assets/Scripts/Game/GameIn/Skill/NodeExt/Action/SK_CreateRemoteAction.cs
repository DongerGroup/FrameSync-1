﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BTCore;
using Framework;
using NodeEditor;

namespace Game
{
    public class SK_CreateRemoteActionData
    {
        [NEProperty("触发时间",true)]
        public FP time;
        public int remoteId;
    }
    [SkillNode(typeof(SK_CreateRemoteActionData))]
    public class SK_CreateRemoteAction : BaseTimeLineSkillAction
    {
        private SK_CreateRemoteActionData m_cActionData;
        public override FP time { get { return m_cActionData.time; } }

        protected override void OnInitData(object data)
        {
            base.OnInitData(data);
            m_cActionData = data as SK_CreateRemoteActionData;
        }

        public override BTActionResult OnRun(SkillBlackBoard blackBoard)
        {
            Skill skill = blackBoard.skill;
            AgentObject host = skill.host;
            BattleScene.Instance.CreateRemote(m_cActionData.remoteId, host.curPosition, host.curForward, 0, AgentObjectType.Unit, host.curPosition, host.curForward);
            return BTActionResult.Ready;
        }
    }
}