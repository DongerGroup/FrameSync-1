//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: protofiles/PacketOpcode.proto
namespace Proto
{
    [global::ProtoBuf.ProtoContract(Name=@"PacketOpcode")]
    public enum PacketOpcode
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"Msg_Test", Value=257)]
      Msg_Test = 257,
            
      [global::ProtoBuf.ProtoEnum(Name=@"C2S_JoinOrCreateRoom", Value=1000)]
      C2S_JoinOrCreateRoom = 1000,
            
      [global::ProtoBuf.ProtoEnum(Name=@"S2C_JoinOrCreateRoom", Value=1001)]
      S2C_JoinOrCreateRoom = 1001,
            
      [global::ProtoBuf.ProtoEnum(Name=@"C2S_GameReady", Value=1002)]
      C2S_GameReady = 1002,
            
      [global::ProtoBuf.ProtoEnum(Name=@"S2C_StartBattle", Value=1003)]
      S2C_StartBattle = 1003,
            
      [global::ProtoBuf.ProtoEnum(Name=@"Frame_Msg_Test", Value=10000)]
      Frame_Msg_Test = 10000,
            
      [global::ProtoBuf.ProtoEnum(Name=@"Frame_CreatePlayer", Value=10001)]
      Frame_CreatePlayer = 10001,
            
      [global::ProtoBuf.ProtoEnum(Name=@"Frame_ReqMovePath", Value=10002)]
      Frame_ReqMovePath = 10002,
            
      [global::ProtoBuf.ProtoEnum(Name=@"Frame_ReqMovePoint", Value=10003)]
      Frame_ReqMovePoint = 10003,
            
      [global::ProtoBuf.ProtoEnum(Name=@"Frame_ReqSetPosition", Value=10004)]
      Frame_ReqSetPosition = 10004,
            
      [global::ProtoBuf.ProtoEnum(Name=@"Frame_ReqSetForward", Value=10005)]
      Frame_ReqSetForward = 10005,
            
      [global::ProtoBuf.ProtoEnum(Name=@"Frame_ReqMoveForward", Value=10006)]
      Frame_ReqMoveForward = 10006,
            
      [global::ProtoBuf.ProtoEnum(Name=@"Frame_ReqStopMove", Value=10007)]
      Frame_ReqStopMove = 10007,
            
      [global::ProtoBuf.ProtoEnum(Name=@"Frame_ReqDoSkill", Value=10008)]
      Frame_ReqDoSkill = 10008,
            
      [global::ProtoBuf.ProtoEnum(Name=@"Frame_ReqBreakSkill", Value=10009)]
      Frame_ReqBreakSkill = 10009
    }
  
}