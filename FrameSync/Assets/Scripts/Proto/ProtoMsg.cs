//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: protofiles/Msg.proto
namespace Proto
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ProtoVector2")]
  public partial class ProtoVector2 : global::ProtoBuf.IExtensible
  {
    public ProtoVector2() {}
    
    private long _x;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"x", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public long x
    {
      get { return _x; }
      set { _x = value; }
    }
    private long _y;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"y", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public long y
    {
      get { return _y; }
      set { _y = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Msg_Test_Data")]
  public partial class Msg_Test_Data : global::ProtoBuf.IExtensible
  {
    public Msg_Test_Data() {}
    
    private string _msg;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"msg", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string msg
    {
      get { return _msg; }
      set { _msg = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"C2S_JoinOrCreateRoom_Data")]
  public partial class C2S_JoinOrCreateRoom_Data : global::ProtoBuf.IExtensible
  {
    public C2S_JoinOrCreateRoom_Data() {}
    
    private int _roomId;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"roomId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int roomId
    {
      get { return _roomId; }
      set { _roomId = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"S2C_JoinOrCreateRoom_Data")]
  public partial class S2C_JoinOrCreateRoom_Data : global::ProtoBuf.IExtensible
  {
    public S2C_JoinOrCreateRoom_Data() {}
    
    private bool _status;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"status", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public bool status
    {
      get { return _status; }
      set { _status = value; }
    }
    private int _roomId = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"roomId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int roomId
    {
      get { return _roomId; }
      set { _roomId = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"C2S_GameReady_Data")]
  public partial class C2S_GameReady_Data : global::ProtoBuf.IExtensible
  {
    public C2S_GameReady_Data() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"S2C_StartBattle_Data")]
  public partial class S2C_StartBattle_Data : global::ProtoBuf.IExtensible
  {
    public S2C_StartBattle_Data() {}
    
    private int _seed;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"seed", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int seed
    {
      get { return _seed; }
      set { _seed = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Frame_Msg_Test_Data")]
  public partial class Frame_Msg_Test_Data : global::ProtoBuf.IExtensible
  {
    public Frame_Msg_Test_Data() {}
    
    private string _msg;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"msg", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string msg
    {
      get { return _msg; }
      set { _msg = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Frame_CreatePlayer_Data")]
  public partial class Frame_CreatePlayer_Data : global::ProtoBuf.IExtensible
  {
    public Frame_CreatePlayer_Data() {}
    
    private long _playerId;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"playerId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public long playerId
    {
      get { return _playerId; }
      set { _playerId = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Frame_ReqMovePath_Data")]
  public partial class Frame_ReqMovePath_Data : global::ProtoBuf.IExtensible
  {
    public Frame_ReqMovePath_Data() {}
    
    private uint _unitId;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"unitId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint unitId
    {
      get { return _unitId; }
      set { _unitId = value; }
    }
    private readonly global::System.Collections.Generic.List<Proto.ProtoVector2> _paths = new global::System.Collections.Generic.List<Proto.ProtoVector2>();
    [global::ProtoBuf.ProtoMember(2, Name=@"paths", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<Proto.ProtoVector2> paths
    {
      get { return _paths; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Frame_ReqMovePoint_Data")]
  public partial class Frame_ReqMovePoint_Data : global::ProtoBuf.IExtensible
  {
    public Frame_ReqMovePoint_Data() {}
    
    private uint _unitId;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"unitId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint unitId
    {
      get { return _unitId; }
      set { _unitId = value; }
    }
    private Proto.ProtoVector2 _targetPosition;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"targetPosition", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public Proto.ProtoVector2 targetPosition
    {
      get { return _targetPosition; }
      set { _targetPosition = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Frame_ReqSetPosition_Data")]
  public partial class Frame_ReqSetPosition_Data : global::ProtoBuf.IExtensible
  {
    public Frame_ReqSetPosition_Data() {}
    
    private uint _unitId;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"unitId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint unitId
    {
      get { return _unitId; }
      set { _unitId = value; }
    }
    private Proto.ProtoVector2 _position;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"position", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public Proto.ProtoVector2 position
    {
      get { return _position; }
      set { _position = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Frame_ReqSetForward_Data")]
  public partial class Frame_ReqSetForward_Data : global::ProtoBuf.IExtensible
  {
    public Frame_ReqSetForward_Data() {}
    
    private uint _unitId;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"unitId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint unitId
    {
      get { return _unitId; }
      set { _unitId = value; }
    }
    private Proto.ProtoVector2 _forward;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"forward", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public Proto.ProtoVector2 forward
    {
      get { return _forward; }
      set { _forward = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Frame_ReqMoveForward_Data")]
  public partial class Frame_ReqMoveForward_Data : global::ProtoBuf.IExtensible
  {
    public Frame_ReqMoveForward_Data() {}
    
    private uint _unitId;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"unitId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint unitId
    {
      get { return _unitId; }
      set { _unitId = value; }
    }
    private Proto.ProtoVector2 _forward;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"forward", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public Proto.ProtoVector2 forward
    {
      get { return _forward; }
      set { _forward = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Frame_ReqStopMove_Data")]
  public partial class Frame_ReqStopMove_Data : global::ProtoBuf.IExtensible
  {
    public Frame_ReqStopMove_Data() {}
    
    private uint _unitId;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"unitId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint unitId
    {
      get { return _unitId; }
      set { _unitId = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}