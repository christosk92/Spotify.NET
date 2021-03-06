// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: spotify/login5/v3/challenges/hashcash.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace CPlayerLib.Login5.V3.Challenges {

  /// <summary>Holder for reflection information generated from spotify/login5/v3/challenges/hashcash.proto</summary>
  public static partial class HashcashReflection {

    #region Descriptor
    /// <summary>File descriptor for spotify/login5/v3/challenges/hashcash.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static HashcashReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CitzcG90aWZ5L2xvZ2luNS92My9jaGFsbGVuZ2VzL2hhc2hjYXNoLnByb3Rv",
            "EhxzcG90aWZ5LmxvZ2luNS52My5jaGFsbGVuZ2VzGh5nb29nbGUvcHJvdG9i",
            "dWYvZHVyYXRpb24ucHJvdG8iMwoRSGFzaGNhc2hDaGFsbGVuZ2USDgoGcHJl",
            "Zml4GAEgASgMEg4KBmxlbmd0aBgCIAEoBSJPChBIYXNoY2FzaFNvbHV0aW9u",
            "Eg4KBnN1ZmZpeBgBIAEoDBIrCghkdXJhdGlvbhgCIAEoCzIZLmdvb2dsZS5w",
            "cm90b2J1Zi5EdXJhdGlvbkIWChRjb20uc3BvdGlmeS5sb2dpbjV2M2IGcHJv",
            "dG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.DurationReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::CPlayerLib.Login5.V3.Challenges.HashcashChallenge), global::CPlayerLib.Login5.V3.Challenges.HashcashChallenge.Parser, new[]{ "Prefix", "Length" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::CPlayerLib.Login5.V3.Challenges.HashcashSolution), global::CPlayerLib.Login5.V3.Challenges.HashcashSolution.Parser, new[]{ "Suffix", "Duration" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class HashcashChallenge : pb::IMessage<HashcashChallenge>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<HashcashChallenge> _parser = new pb::MessageParser<HashcashChallenge>(() => new HashcashChallenge());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<HashcashChallenge> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::CPlayerLib.Login5.V3.Challenges.HashcashReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public HashcashChallenge() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public HashcashChallenge(HashcashChallenge other) : this() {
      prefix_ = other.prefix_;
      length_ = other.length_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public HashcashChallenge Clone() {
      return new HashcashChallenge(this);
    }

    /// <summary>Field number for the "prefix" field.</summary>
    public const int PrefixFieldNumber = 1;
    private pb::ByteString prefix_ = pb::ByteString.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pb::ByteString Prefix {
      get { return prefix_; }
      set {
        prefix_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "length" field.</summary>
    public const int LengthFieldNumber = 2;
    private int length_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Length {
      get { return length_; }
      set {
        length_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as HashcashChallenge);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(HashcashChallenge other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Prefix != other.Prefix) return false;
      if (Length != other.Length) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Prefix.Length != 0) hash ^= Prefix.GetHashCode();
      if (Length != 0) hash ^= Length.GetHashCode();
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
      if (Prefix.Length != 0) {
        output.WriteRawTag(10);
        output.WriteBytes(Prefix);
      }
      if (Length != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Length);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Prefix.Length != 0) {
        output.WriteRawTag(10);
        output.WriteBytes(Prefix);
      }
      if (Length != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Length);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Prefix.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(Prefix);
      }
      if (Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Length);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(HashcashChallenge other) {
      if (other == null) {
        return;
      }
      if (other.Prefix.Length != 0) {
        Prefix = other.Prefix;
      }
      if (other.Length != 0) {
        Length = other.Length;
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
          case 10: {
            Prefix = input.ReadBytes();
            break;
          }
          case 16: {
            Length = input.ReadInt32();
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
          case 10: {
            Prefix = input.ReadBytes();
            break;
          }
          case 16: {
            Length = input.ReadInt32();
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class HashcashSolution : pb::IMessage<HashcashSolution>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<HashcashSolution> _parser = new pb::MessageParser<HashcashSolution>(() => new HashcashSolution());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<HashcashSolution> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::CPlayerLib.Login5.V3.Challenges.HashcashReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public HashcashSolution() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public HashcashSolution(HashcashSolution other) : this() {
      suffix_ = other.suffix_;
      duration_ = other.duration_ != null ? other.duration_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public HashcashSolution Clone() {
      return new HashcashSolution(this);
    }

    /// <summary>Field number for the "suffix" field.</summary>
    public const int SuffixFieldNumber = 1;
    private pb::ByteString suffix_ = pb::ByteString.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pb::ByteString Suffix {
      get { return suffix_; }
      set {
        suffix_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "duration" field.</summary>
    public const int DurationFieldNumber = 2;
    private global::Google.Protobuf.WellKnownTypes.Duration duration_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Duration Duration {
      get { return duration_; }
      set {
        duration_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as HashcashSolution);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(HashcashSolution other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Suffix != other.Suffix) return false;
      if (!object.Equals(Duration, other.Duration)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Suffix.Length != 0) hash ^= Suffix.GetHashCode();
      if (duration_ != null) hash ^= Duration.GetHashCode();
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
      if (Suffix.Length != 0) {
        output.WriteRawTag(10);
        output.WriteBytes(Suffix);
      }
      if (duration_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Duration);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Suffix.Length != 0) {
        output.WriteRawTag(10);
        output.WriteBytes(Suffix);
      }
      if (duration_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Duration);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Suffix.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(Suffix);
      }
      if (duration_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Duration);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(HashcashSolution other) {
      if (other == null) {
        return;
      }
      if (other.Suffix.Length != 0) {
        Suffix = other.Suffix;
      }
      if (other.duration_ != null) {
        if (duration_ == null) {
          Duration = new global::Google.Protobuf.WellKnownTypes.Duration();
        }
        Duration.MergeFrom(other.Duration);
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
          case 10: {
            Suffix = input.ReadBytes();
            break;
          }
          case 18: {
            if (duration_ == null) {
              Duration = new global::Google.Protobuf.WellKnownTypes.Duration();
            }
            input.ReadMessage(Duration);
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
          case 10: {
            Suffix = input.ReadBytes();
            break;
          }
          case 18: {
            if (duration_ == null) {
              Duration = new global::Google.Protobuf.WellKnownTypes.Duration();
            }
            input.ReadMessage(Duration);
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
