// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: characters/characters.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Mruv {

  /// <summary>Holder for reflection information generated from characters/characters.proto</summary>
  public static partial class CharactersReflection {

    #region Descriptor
    /// <summary>File descriptor for characters/characters.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CharactersReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChtjaGFyYWN0ZXJzL2NoYXJhY3RlcnMucHJvdG8SBG1ydXYaHGdvb2dsZS9h",
            "cGkvYW5ub3RhdGlvbnMucHJvdG8aE2NvbW1vbi9oZWFsdGgucHJvdG8aIWNo",
            "YXJhY3RlcnMvY2hhcmFjdGVyc19tb2RlbC5wcm90byI6ChJEZWF0aFN0cmVh",
            "bVJlcXVlc3QSJAoLZGVhdGhfdHlwZXMYASADKA4yDy5tcnV2LkRlYXRoVHlw",
            "ZSJeChNEZWF0aFN0cmVhbVJlc3BvbnNlEiIKCWNoYXJhY3RlchgBIAEoCzIP",
            "Lm1ydXYuQ2hhcmFjdGVyEiMKCmRlYXRoX3R5cGUYAiABKA4yDy5tcnV2LkRl",
            "YXRoVHlwZTKtBQoVTXJ1VkNoYXJhY3RlcnNTZXJ2aWNlEkQKBkNyZWF0ZRIP",
            "Lm1ydXYuQ2hhcmFjdGVyGhEubXJ1di5DaGFyYWN0ZXJJRCIWgtPkkwIQIg4v",
            "djEvY2hhcmFjdGVycxJGCgNHZXQSES5tcnV2LkNoYXJhY3RlcklEGg8ubXJ1",
            "di5DaGFyYWN0ZXIiG4LT5JMCFRITL3YxL2NoYXJhY3RlcnMve2lkfRJJCgZV",
            "cGRhdGUSDy5tcnV2LkNoYXJhY3RlchoRLm1ydXYuQ2hhcmFjdGVySUQiG4LT",
            "5JMCFTITL3YxL2NoYXJhY3RlcnMve2lkfRJLCgZSZW1vdmUSES5tcnV2LkNo",
            "YXJhY3RlcklEGhEubXJ1di5DaGFyYWN0ZXJJRCIbgtPkkwIVKhMvdjEvY2hh",
            "cmFjdGVycy97aWR9ElcKDUtpbGxDaGFyYWN0ZXISES5tcnV2LkNoYXJhY3Rl",
            "cklEGhEubXJ1di5DaGFyYWN0ZXJJRCIggtPkkwIaKhgvdjEvY2hhcmFjdGVy",
            "cy9raWxsL3tpZH0SRwoMRGVhdGhzU3RyZWFtEhgubXJ1di5EZWF0aFN0cmVh",
            "bVJlcXVlc3QaGS5tcnV2LkRlYXRoU3RyZWFtUmVzcG9uc2UiADABEmoKEEdl",
            "dFNlcnZpY2VTdGF0dXMSGi5tcnV2LlNlcnZpY2VTdGF0dXNSZXF1ZXN0Ghsu",
            "bXJ1di5TZXJ2aWNlU3RhdHVzUmVzcG9uc2UiHYLT5JMCFxIVL2NoYXJhY3Rl",
            "cnMvdjEvc3RhdHVzEmAKEUdldFNlcnZpY2VWZXJzaW9uEhQubXJ1di5WZXJz",
            "aW9uUmVxdWVzdBoVLm1ydXYuVmVyc2lvblJlc3BvbnNlIh6C0+STAhgSFi9j",
            "aGFyYWN0ZXJzL3YxL3ZlcnNpb25CKlooZ2l0aHViLmNvbS9NcnVWLVJQL21y",
            "dXYtcGItZ28vY2hhcmFjdGVyc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, global::Mruv.HealthReflection.Descriptor, global::Mruv.CharactersModelReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Mruv.DeathStreamRequest), global::Mruv.DeathStreamRequest.Parser, new[]{ "DeathTypes" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Mruv.DeathStreamResponse), global::Mruv.DeathStreamResponse.Parser, new[]{ "Character", "DeathType" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  ///requests &amp; response messages
  /// </summary>
  public sealed partial class DeathStreamRequest : pb::IMessage<DeathStreamRequest> {
    private static readonly pb::MessageParser<DeathStreamRequest> _parser = new pb::MessageParser<DeathStreamRequest>(() => new DeathStreamRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<DeathStreamRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Mruv.CharactersReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DeathStreamRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DeathStreamRequest(DeathStreamRequest other) : this() {
      deathTypes_ = other.deathTypes_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DeathStreamRequest Clone() {
      return new DeathStreamRequest(this);
    }

    /// <summary>Field number for the "death_types" field.</summary>
    public const int DeathTypesFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Mruv.DeathType> _repeated_deathTypes_codec
        = pb::FieldCodec.ForEnum(10, x => (int) x, x => (global::Mruv.DeathType) x);
    private readonly pbc::RepeatedField<global::Mruv.DeathType> deathTypes_ = new pbc::RepeatedField<global::Mruv.DeathType>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Mruv.DeathType> DeathTypes {
      get { return deathTypes_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as DeathStreamRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(DeathStreamRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!deathTypes_.Equals(other.deathTypes_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= deathTypes_.GetHashCode();
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
      deathTypes_.WriteTo(output, _repeated_deathTypes_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += deathTypes_.CalculateSize(_repeated_deathTypes_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(DeathStreamRequest other) {
      if (other == null) {
        return;
      }
      deathTypes_.Add(other.deathTypes_);
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
          case 10:
          case 8: {
            deathTypes_.AddEntriesFrom(input, _repeated_deathTypes_codec);
            break;
          }
        }
      }
    }

  }

  public sealed partial class DeathStreamResponse : pb::IMessage<DeathStreamResponse> {
    private static readonly pb::MessageParser<DeathStreamResponse> _parser = new pb::MessageParser<DeathStreamResponse>(() => new DeathStreamResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<DeathStreamResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Mruv.CharactersReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DeathStreamResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DeathStreamResponse(DeathStreamResponse other) : this() {
      character_ = other.character_ != null ? other.character_.Clone() : null;
      deathType_ = other.deathType_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DeathStreamResponse Clone() {
      return new DeathStreamResponse(this);
    }

    /// <summary>Field number for the "character" field.</summary>
    public const int CharacterFieldNumber = 1;
    private global::Mruv.Character character_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Mruv.Character Character {
      get { return character_; }
      set {
        character_ = value;
      }
    }

    /// <summary>Field number for the "death_type" field.</summary>
    public const int DeathTypeFieldNumber = 2;
    private global::Mruv.DeathType deathType_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Mruv.DeathType DeathType {
      get { return deathType_; }
      set {
        deathType_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as DeathStreamResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(DeathStreamResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Character, other.Character)) return false;
      if (DeathType != other.DeathType) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (character_ != null) hash ^= Character.GetHashCode();
      if (DeathType != 0) hash ^= DeathType.GetHashCode();
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
      if (character_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Character);
      }
      if (DeathType != 0) {
        output.WriteRawTag(16);
        output.WriteEnum((int) DeathType);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (character_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Character);
      }
      if (DeathType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) DeathType);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(DeathStreamResponse other) {
      if (other == null) {
        return;
      }
      if (other.character_ != null) {
        if (character_ == null) {
          Character = new global::Mruv.Character();
        }
        Character.MergeFrom(other.Character);
      }
      if (other.DeathType != 0) {
        DeathType = other.DeathType;
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
          case 10: {
            if (character_ == null) {
              Character = new global::Mruv.Character();
            }
            input.ReadMessage(Character);
            break;
          }
          case 16: {
            DeathType = (global::Mruv.DeathType) input.ReadEnum();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
