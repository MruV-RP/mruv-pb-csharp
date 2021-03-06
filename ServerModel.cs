// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: server/server_model.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Mruv.Server {

  /// <summary>Holder for reflection information generated from server/server_model.proto</summary>
  public static partial class ServerModelReflection {

    #region Descriptor
    /// <summary>File descriptor for server/server_model.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ServerModelReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlzZXJ2ZXIvc2VydmVyX21vZGVsLnByb3RvEgttcnV2LnNlcnZlciIWCghT",
            "ZXJ2ZXJJRBIKCgJpZBgBIAEoDSKQAQoKU2VydmVySW5mbxIKCgJpZBgBIAEo",
            "DRIMCgRuYW1lGAIgASgJEgwKBGhvc3QYAyABKAkSDAoEcG9ydBgEIAEoCRIQ",
            "CghwbGF0Zm9ybRgFIAEoCRIpCgZzdGF0dXMYBiABKA4yGS5tcnV2LnNlcnZl",
            "ci5TZXJ2ZXJTdGF0dXMSDwoHcGxheWVycxgHIAEoDSosCgxTZXJ2ZXJTdGF0",
            "dXMSCwoHVU5LTk9XThAAEgYKAk9OEAESBwoDT0ZGEAJCJlokZ2l0aHViLmNv",
            "bS9NcnVWLVJQL21ydXYtcGItZ28vc2VydmVyYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Mruv.Server.ServerStatus), }, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Mruv.Server.ServerID), global::Mruv.Server.ServerID.Parser, new[]{ "Id" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Mruv.Server.ServerInfo), global::Mruv.Server.ServerInfo.Parser, new[]{ "Id", "Name", "Host", "Port", "Platform", "Status", "Players" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  public enum ServerStatus {
    [pbr::OriginalName("UNKNOWN")] Unknown = 0,
    [pbr::OriginalName("ON")] On = 1,
    [pbr::OriginalName("OFF")] Off = 2,
  }

  #endregion

  #region Messages
  public sealed partial class ServerID : pb::IMessage<ServerID>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ServerID> _parser = new pb::MessageParser<ServerID>(() => new ServerID());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ServerID> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Mruv.Server.ServerModelReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ServerID() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ServerID(ServerID other) : this() {
      id_ = other.id_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ServerID Clone() {
      return new ServerID(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private uint id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ServerID);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ServerID other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id != 0) hash ^= Id.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Id != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Id);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Id != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Id);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Id);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ServerID other) {
      if (other == null) {
        return;
      }
      if (other.Id != 0) {
        Id = other.Id;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            Id = input.ReadUInt32();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 8: {
            Id = input.ReadUInt32();
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// Data that describe server.
  /// </summary>
  public sealed partial class ServerInfo : pb::IMessage<ServerInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ServerInfo> _parser = new pb::MessageParser<ServerInfo>(() => new ServerInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ServerInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Mruv.Server.ServerModelReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ServerInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ServerInfo(ServerInfo other) : this() {
      id_ = other.id_;
      name_ = other.name_;
      host_ = other.host_;
      port_ = other.port_;
      platform_ = other.platform_;
      status_ = other.status_;
      players_ = other.players_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ServerInfo Clone() {
      return new ServerInfo(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private uint id_;
    /// <summary>
    /// Id of the server.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 2;
    private string name_ = "";
    /// <summary>
    /// Short name of the server.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "host" field.</summary>
    public const int HostFieldNumber = 3;
    private string host_ = "";
    /// <summary>
    /// Host (ip) of the server.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Host {
      get { return host_; }
      set {
        host_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "port" field.</summary>
    public const int PortFieldNumber = 4;
    private string port_ = "";
    /// <summary>
    /// Port of the server.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Port {
      get { return port_; }
      set {
        port_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "platform" field.</summary>
    public const int PlatformFieldNumber = 5;
    private string platform_ = "";
    /// <summary>
    /// Platform of the server.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Platform {
      get { return platform_; }
      set {
        platform_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 6;
    private global::Mruv.Server.ServerStatus status_ = global::Mruv.Server.ServerStatus.Unknown;
    /// <summary>
    /// Status of the server.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Mruv.Server.ServerStatus Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    /// <summary>Field number for the "players" field.</summary>
    public const int PlayersFieldNumber = 7;
    private uint players_;
    /// <summary>
    /// How many players are playing on the server.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint Players {
      get { return players_; }
      set {
        players_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ServerInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ServerInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (Name != other.Name) return false;
      if (Host != other.Host) return false;
      if (Port != other.Port) return false;
      if (Platform != other.Platform) return false;
      if (Status != other.Status) return false;
      if (Players != other.Players) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id != 0) hash ^= Id.GetHashCode();
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (Host.Length != 0) hash ^= Host.GetHashCode();
      if (Port.Length != 0) hash ^= Port.GetHashCode();
      if (Platform.Length != 0) hash ^= Platform.GetHashCode();
      if (Status != global::Mruv.Server.ServerStatus.Unknown) hash ^= Status.GetHashCode();
      if (Players != 0) hash ^= Players.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Id != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Id);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Name);
      }
      if (Host.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Host);
      }
      if (Port.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Port);
      }
      if (Platform.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(Platform);
      }
      if (Status != global::Mruv.Server.ServerStatus.Unknown) {
        output.WriteRawTag(48);
        output.WriteEnum((int) Status);
      }
      if (Players != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(Players);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Id != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Id);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Name);
      }
      if (Host.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Host);
      }
      if (Port.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Port);
      }
      if (Platform.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(Platform);
      }
      if (Status != global::Mruv.Server.ServerStatus.Unknown) {
        output.WriteRawTag(48);
        output.WriteEnum((int) Status);
      }
      if (Players != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(Players);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Id);
      }
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (Host.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Host);
      }
      if (Port.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Port);
      }
      if (Platform.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Platform);
      }
      if (Status != global::Mruv.Server.ServerStatus.Unknown) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      if (Players != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Players);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ServerInfo other) {
      if (other == null) {
        return;
      }
      if (other.Id != 0) {
        Id = other.Id;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.Host.Length != 0) {
        Host = other.Host;
      }
      if (other.Port.Length != 0) {
        Port = other.Port;
      }
      if (other.Platform.Length != 0) {
        Platform = other.Platform;
      }
      if (other.Status != global::Mruv.Server.ServerStatus.Unknown) {
        Status = other.Status;
      }
      if (other.Players != 0) {
        Players = other.Players;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            Id = input.ReadUInt32();
            break;
          }
          case 18: {
            Name = input.ReadString();
            break;
          }
          case 26: {
            Host = input.ReadString();
            break;
          }
          case 34: {
            Port = input.ReadString();
            break;
          }
          case 42: {
            Platform = input.ReadString();
            break;
          }
          case 48: {
            Status = (global::Mruv.Server.ServerStatus) input.ReadEnum();
            break;
          }
          case 56: {
            Players = input.ReadUInt32();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 8: {
            Id = input.ReadUInt32();
            break;
          }
          case 18: {
            Name = input.ReadString();
            break;
          }
          case 26: {
            Host = input.ReadString();
            break;
          }
          case 34: {
            Port = input.ReadString();
            break;
          }
          case 42: {
            Platform = input.ReadString();
            break;
          }
          case 48: {
            Status = (global::Mruv.Server.ServerStatus) input.ReadEnum();
            break;
          }
          case 56: {
            Players = input.ReadUInt32();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
