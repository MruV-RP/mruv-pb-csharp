// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: server/server.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Mruv.Server {

  /// <summary>Holder for reflection information generated from server/server.proto</summary>
  public static partial class ServerReflection {

    #region Descriptor
    /// <summary>File descriptor for server/server.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ServerReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChNzZXJ2ZXIvc2VydmVyLnByb3RvEgttcnV2LnNlcnZlchocZ29vZ2xlL2Fw",
            "aS9hbm5vdGF0aW9ucy5wcm90bxoZc2VydmVyL3NlcnZlcl9tb2RlbC5wcm90",
            "byIdChtHZXRSZWdpc3RlcmVkU2VydmVyc1JlcXVlc3QiSAocR2V0UmVnaXN0",
            "ZXJlZFNlcnZlcnNSZXNwb25zZRIoCgdzZXJ2ZXJzGAEgAygLMhcubXJ1di5z",
            "ZXJ2ZXIuU2VydmVySW5mbyJjChlVcGRhdGVTZXJ2ZXJTdGF0dXNSZXF1ZXN0",
            "EgoKAmlkGAEgASgDEikKBnN0YXR1cxgCIAEoDjIZLm1ydXYuc2VydmVyLlNl",
            "cnZlclN0YXR1cxIPCgdwbGF5ZXJzGAMgASgFIhwKGlVwZGF0ZVNlcnZlclN0",
            "YXR1c1Jlc3BvbnNlIicKGVNlcnZlckV2ZW50c1N0cmVhbVJlcXVlc3QSCgoC",
            "aWQYASABKAMiqgEKC1NlcnZlckV2ZW50EjYKBHR5cGUYASABKA4yKC5tcnV2",
            "LnNlcnZlci5TZXJ2ZXJFdmVudC5TZXJ2ZXJFdmVudFR5cGUiYwoPU2VydmVy",
            "RXZlbnRUeXBlEgsKB1VOS05PV04QABIOCgpSRUdJU1RFUkVEEAESDwoLU0VS",
            "VkVSX0RPV04QAhINCglTRVJWRVJfVVAQAxITCg9QTEFZRVJTX0NIQU5HRUQQ",
            "BDKtBAoRTXJ1VlNlcnZlclNlcnZpY2USVQoOUmVnaXN0ZXJTZXJ2ZXISFy5t",
            "cnV2LnNlcnZlci5TZXJ2ZXJJbmZvGhUubXJ1di5zZXJ2ZXIuU2VydmVySUQi",
            "E4LT5JMCDSILL3YxL3NlcnZlcnMSgAEKFEdldFJlZ2lzdGVyZWRTZXJ2ZXJz",
            "EigubXJ1di5zZXJ2ZXIuR2V0UmVnaXN0ZXJlZFNlcnZlcnNSZXF1ZXN0Giku",
            "bXJ1di5zZXJ2ZXIuR2V0UmVnaXN0ZXJlZFNlcnZlcnNSZXNwb25zZSITgtPk",
            "kwINEgsvdjEvc2VydmVycxJZCg1HZXRTZXJ2ZXJJbmZvEhUubXJ1di5zZXJ2",
            "ZXIuU2VydmVySUQaFy5tcnV2LnNlcnZlci5TZXJ2ZXJJbmZvIhiC0+STAhIS",
            "EC92MS9zZXJ2ZXJzL3tpZH0ShgEKElVwZGF0ZVNlcnZlclN0YXR1cxImLm1y",
            "dXYuc2VydmVyLlVwZGF0ZVNlcnZlclN0YXR1c1JlcXVlc3QaJy5tcnV2LnNl",
            "cnZlci5VcGRhdGVTZXJ2ZXJTdGF0dXNSZXNwb25zZSIfgtPkkwIZMhcvdjEv",
            "c2VydmVycy97aWR9L3N0YXR1cxJaChJTZXJ2ZXJFdmVudHNTdHJlYW0SJi5t",
            "cnV2LnNlcnZlci5TZXJ2ZXJFdmVudHNTdHJlYW1SZXF1ZXN0GhgubXJ1di5z",
            "ZXJ2ZXIuU2VydmVyRXZlbnQiADABQiZaJGdpdGh1Yi5jb20vTXJ1Vi1SUC9t",
            "cnV2LXBiLWdvL3NlcnZlcmIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, global::Mruv.Server.ServerModelReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Mruv.Server.GetRegisteredServersRequest), global::Mruv.Server.GetRegisteredServersRequest.Parser, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Mruv.Server.GetRegisteredServersResponse), global::Mruv.Server.GetRegisteredServersResponse.Parser, new[]{ "Servers" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Mruv.Server.UpdateServerStatusRequest), global::Mruv.Server.UpdateServerStatusRequest.Parser, new[]{ "Id", "Status", "Players" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Mruv.Server.UpdateServerStatusResponse), global::Mruv.Server.UpdateServerStatusResponse.Parser, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Mruv.Server.ServerEventsStreamRequest), global::Mruv.Server.ServerEventsStreamRequest.Parser, new[]{ "Id" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Mruv.Server.ServerEvent), global::Mruv.Server.ServerEvent.Parser, new[]{ "Type" }, null, new[]{ typeof(global::Mruv.Server.ServerEvent.Types.ServerEventType) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Request message for `MruVServerService.GetRegisteredServers`.
  /// </summary>
  public sealed partial class GetRegisteredServersRequest : pb::IMessage<GetRegisteredServersRequest> {
    private static readonly pb::MessageParser<GetRegisteredServersRequest> _parser = new pb::MessageParser<GetRegisteredServersRequest>(() => new GetRegisteredServersRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetRegisteredServersRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Mruv.Server.ServerReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetRegisteredServersRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetRegisteredServersRequest(GetRegisteredServersRequest other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetRegisteredServersRequest Clone() {
      return new GetRegisteredServersRequest(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetRegisteredServersRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetRegisteredServersRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
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
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GetRegisteredServersRequest other) {
      if (other == null) {
        return;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
        }
      }
    }

  }

  /// <summary>
  /// Response message for `MruVServerService.GetRegisteredServers`.
  /// </summary>
  public sealed partial class GetRegisteredServersResponse : pb::IMessage<GetRegisteredServersResponse> {
    private static readonly pb::MessageParser<GetRegisteredServersResponse> _parser = new pb::MessageParser<GetRegisteredServersResponse>(() => new GetRegisteredServersResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetRegisteredServersResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Mruv.Server.ServerReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetRegisteredServersResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetRegisteredServersResponse(GetRegisteredServersResponse other) : this() {
      servers_ = other.servers_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetRegisteredServersResponse Clone() {
      return new GetRegisteredServersResponse(this);
    }

    /// <summary>Field number for the "servers" field.</summary>
    public const int ServersFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Mruv.Server.ServerInfo> _repeated_servers_codec
        = pb::FieldCodec.ForMessage(10, global::Mruv.Server.ServerInfo.Parser);
    private readonly pbc::RepeatedField<global::Mruv.Server.ServerInfo> servers_ = new pbc::RepeatedField<global::Mruv.Server.ServerInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Mruv.Server.ServerInfo> Servers {
      get { return servers_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetRegisteredServersResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetRegisteredServersResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!servers_.Equals(other.servers_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= servers_.GetHashCode();
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
      servers_.WriteTo(output, _repeated_servers_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += servers_.CalculateSize(_repeated_servers_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GetRegisteredServersResponse other) {
      if (other == null) {
        return;
      }
      servers_.Add(other.servers_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            servers_.AddEntriesFrom(input, _repeated_servers_codec);
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// Request message for `MruVServerService.UpdateServerStatus`.
  /// </summary>
  public sealed partial class UpdateServerStatusRequest : pb::IMessage<UpdateServerStatusRequest> {
    private static readonly pb::MessageParser<UpdateServerStatusRequest> _parser = new pb::MessageParser<UpdateServerStatusRequest>(() => new UpdateServerStatusRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<UpdateServerStatusRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Mruv.Server.ServerReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UpdateServerStatusRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UpdateServerStatusRequest(UpdateServerStatusRequest other) : this() {
      id_ = other.id_;
      status_ = other.status_;
      players_ = other.players_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UpdateServerStatusRequest Clone() {
      return new UpdateServerStatusRequest(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private long id_;
    /// <summary>
    /// Id of the server.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 2;
    private global::Mruv.Server.ServerStatus status_ = 0;
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
    public const int PlayersFieldNumber = 3;
    private int players_;
    /// <summary>
    /// How many players are registered on that server.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Players {
      get { return players_; }
      set {
        players_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as UpdateServerStatusRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(UpdateServerStatusRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (Status != other.Status) return false;
      if (Players != other.Players) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id != 0L) hash ^= Id.GetHashCode();
      if (Status != 0) hash ^= Status.GetHashCode();
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
      if (Id != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(Id);
      }
      if (Status != 0) {
        output.WriteRawTag(16);
        output.WriteEnum((int) Status);
      }
      if (Players != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(Players);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Id);
      }
      if (Status != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      if (Players != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Players);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(UpdateServerStatusRequest other) {
      if (other == null) {
        return;
      }
      if (other.Id != 0L) {
        Id = other.Id;
      }
      if (other.Status != 0) {
        Status = other.Status;
      }
      if (other.Players != 0) {
        Players = other.Players;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            Id = input.ReadInt64();
            break;
          }
          case 16: {
            Status = (global::Mruv.Server.ServerStatus) input.ReadEnum();
            break;
          }
          case 24: {
            Players = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// Response message for `MruVServerService.UpdateServerStatus`.
  /// </summary>
  public sealed partial class UpdateServerStatusResponse : pb::IMessage<UpdateServerStatusResponse> {
    private static readonly pb::MessageParser<UpdateServerStatusResponse> _parser = new pb::MessageParser<UpdateServerStatusResponse>(() => new UpdateServerStatusResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<UpdateServerStatusResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Mruv.Server.ServerReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UpdateServerStatusResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UpdateServerStatusResponse(UpdateServerStatusResponse other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UpdateServerStatusResponse Clone() {
      return new UpdateServerStatusResponse(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as UpdateServerStatusResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(UpdateServerStatusResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
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
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(UpdateServerStatusResponse other) {
      if (other == null) {
        return;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
        }
      }
    }

  }

  /// <summary>
  /// Request message for `MruVServerService.ServerEventsStream`.
  /// </summary>
  public sealed partial class ServerEventsStreamRequest : pb::IMessage<ServerEventsStreamRequest> {
    private static readonly pb::MessageParser<ServerEventsStreamRequest> _parser = new pb::MessageParser<ServerEventsStreamRequest>(() => new ServerEventsStreamRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ServerEventsStreamRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Mruv.Server.ServerReflection.Descriptor.MessageTypes[4]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ServerEventsStreamRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ServerEventsStreamRequest(ServerEventsStreamRequest other) : this() {
      id_ = other.id_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ServerEventsStreamRequest Clone() {
      return new ServerEventsStreamRequest(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private long id_;
    /// <summary>
    /// The ID of the server from which we want to receive events.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ServerEventsStreamRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ServerEventsStreamRequest other) {
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
      if (Id != 0L) hash ^= Id.GetHashCode();
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
      if (Id != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(Id);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Id);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ServerEventsStreamRequest other) {
      if (other == null) {
        return;
      }
      if (other.Id != 0L) {
        Id = other.Id;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            Id = input.ReadInt64();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// Server event.
  /// Response message for `MruVServerService.ServerEventsStream`.
  /// </summary>
  public sealed partial class ServerEvent : pb::IMessage<ServerEvent> {
    private static readonly pb::MessageParser<ServerEvent> _parser = new pb::MessageParser<ServerEvent>(() => new ServerEvent());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ServerEvent> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Mruv.Server.ServerReflection.Descriptor.MessageTypes[5]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ServerEvent() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ServerEvent(ServerEvent other) : this() {
      type_ = other.type_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ServerEvent Clone() {
      return new ServerEvent(this);
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 1;
    private global::Mruv.Server.ServerEvent.Types.ServerEventType type_ = 0;
    /// <summary>
    /// Type of a server event.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Mruv.Server.ServerEvent.Types.ServerEventType Type {
      get { return type_; }
      set {
        type_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ServerEvent);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ServerEvent other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Type != other.Type) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Type != 0) hash ^= Type.GetHashCode();
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
      if (Type != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Type);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Type != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Type);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ServerEvent other) {
      if (other == null) {
        return;
      }
      if (other.Type != 0) {
        Type = other.Type;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            Type = (global::Mruv.Server.ServerEvent.Types.ServerEventType) input.ReadEnum();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the ServerEvent message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Types of server events.
      /// </summary>
      public enum ServerEventType {
        [pbr::OriginalName("UNKNOWN")] Unknown = 0,
        [pbr::OriginalName("REGISTERED")] Registered = 1,
        [pbr::OriginalName("SERVER_DOWN")] ServerDown = 2,
        [pbr::OriginalName("SERVER_UP")] ServerUp = 3,
        [pbr::OriginalName("PLAYERS_CHANGED")] PlayersChanged = 4,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
