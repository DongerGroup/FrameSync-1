﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game
{
    public class GameEvent
    {
        //战斗部分
        public static int StartBattle = "StartBattle".GetHashCode();//开始战斗消息
        public static int PvpPlayerCreate = "PvpPlayerCreate".GetHashCode(); ///战斗玩家创建消息
        public static int UnitAdd = "UnitAdd".GetHashCode();//单位添加
        public static int UnitRemove = "UnitRemove".GetHashCode();//单位移除
    }
}
