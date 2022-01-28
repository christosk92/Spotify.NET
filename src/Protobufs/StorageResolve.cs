// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: storage-resolve.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace CPlayerLib.Download.Proto {

  /// <summary>Holder for reflection information generated from storage-resolve.proto</summary>
  public static partial class StorageResolveReflection {

    #region Descriptor
    /// <summary>File descriptor for storage-resolve.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static StorageResolveReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVzdG9yYWdlLXJlc29sdmUucHJvdG8SFnNwb3RpZnkuZG93bmxvYWQucHJv",
            "dG8irwEKFlN0b3JhZ2VSZXNvbHZlUmVzcG9uc2USRQoGcmVzdWx0GAEgASgO",
            "MjUuc3BvdGlmeS5kb3dubG9hZC5wcm90by5TdG9yYWdlUmVzb2x2ZVJlc3Bv",
            "bnNlLlJlc3VsdBIOCgZjZG51cmwYAiADKAkSDgoGZmlsZWlkGAQgASgMIi4K",
            "BlJlc3VsdBIHCgNDRE4QABILCgdTVE9SQUdFEAESDgoKUkVTVFJJQ1RFRBAD",
            "QhcKE2NvbS5zcG90aWZ5LnN0b3JhZ2VIAmIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::CPlayerLib.Download.Proto.StorageResolveResponse), global::CPlayerLib.Download.Proto.StorageResolveResponse.Parser, new[]{ "Result", "Cdnurl", "Fileid" }, null, new[]{ typeof(global::CPlayerLib.Download.Proto.StorageResolveResponse.Types.Result) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class StorageResolveResponse : pb::IMessage<StorageResolveResponse>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<StorageResolveResponse> _parser = new pb::MessageParser<StorageResolveResponse>(() => new StorageResolveResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<StorageResolveResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::CPlayerLib.Download.Proto.StorageResolveReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public StorageResolveResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public StorageResolveResponse(StorageResolveResponse other) : this() {
      result_ = other.result_;
      cdnurl_ = other.cdnurl_.Clone();
      fileid_ = other.fileid_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public StorageResolveResponse Clone() {
      return new StorageResolveResponse(this);
    }

    /// <summary>Field number for the "result" field.</summary>
    public const int ResultFieldNumber = 1;
    private global::CPlayerLib.Download.Proto.StorageResolveResponse.Types.Result result_ = global::CPlayerLib.Download.Proto.StorageResolveResponse.Types.Result.Cdn;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::CPlayerLib.Download.Proto.StorageResolveResponse.Types.Result Result {
      get { return result_; }
      set {
        result_ = value;
      }
    }

    /// <summary>Field number for the "cdnurl" field.</summary>
    public const int CdnurlFieldNumber = 2;
    private static readonly pb::FieldCodec<string> _repeated_cdnurl_codec
        = pb::FieldCodec.ForString(18);
    private readonly pbc::RepeatedField<string> cdnurl_ = new pbc::RepeatedField<string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> Cdnurl {
      get { return cdnurl_; }
    }

    /// <summary>Field number for the "fileid" field.</summary>
    public const int FileidFieldNumber = 4;
    private pb::ByteString fileid_ = pb::ByteString.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pb::ByteString Fileid {
      get { return fileid_; }
      set {
        fileid_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as StorageResolveResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(StorageResolveResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Result != other.Result) return false;
      if(!cdnurl_.Equals(other.cdnurl_)) return false;
      if (Fileid != other.Fileid) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Result != global::CPlayerLib.Download.Proto.StorageResolveResponse.Types.Result.Cdn) hash ^= Result.GetHashCode();
      hash ^= cdnurl_.GetHashCode();
      if (Fileid.Length != 0) hash ^= Fileid.GetHashCode();
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
      if (Result != global::CPlayerLib.Download.Proto.StorageResolveResponse.Types.Result.Cdn) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Result);
      }
      cdnurl_.WriteTo(output, _repeated_cdnurl_codec);
      if (Fileid.Length != 0) {
        output.WriteRawTag(34);
        output.WriteBytes(Fileid);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Result != global::CPlayerLib.Download.Proto.StorageResolveResponse.Types.Result.Cdn) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Result);
      }
      cdnurl_.WriteTo(ref output, _repeated_cdnurl_codec);
      if (Fileid.Length != 0) {
        output.WriteRawTag(34);
        output.WriteBytes(Fileid);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Result != global::CPlayerLib.Download.Proto.StorageResolveResponse.Types.Result.Cdn) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Result);
      }
      size += cdnurl_.CalculateSize(_repeated_cdnurl_codec);
      if (Fileid.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(Fileid);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(StorageResolveResponse other) {
      if (other == null) {
        return;
      }
      if (other.Result != global::CPlayerLib.Download.Proto.StorageResolveResponse.Types.Result.Cdn) {
        Result = other.Result;
      }
      cdnurl_.Add(other.cdnurl_);
      if (other.Fileid.Length != 0) {
        Fileid = other.Fileid;
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
            Result = (global::CPlayerLib.Download.Proto.StorageResolveResponse.Types.Result) input.ReadEnum();
            break;
          }
          case 18: {
            cdnurl_.AddEntriesFrom(input, _repeated_cdnurl_codec);
            break;
          }
          case 34: {
            Fileid = input.ReadBytes();
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
            Result = (global::CPlayerLib.Download.Proto.StorageResolveResponse.Types.Result) input.ReadEnum();
            break;
          }
          case 18: {
            cdnurl_.AddEntriesFrom(ref input, _repeated_cdnurl_codec);
            break;
          }
          case 34: {
            Fileid = input.ReadBytes();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the StorageResolveResponse message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public enum Result {
        [pbr::OriginalName("CDN")] Cdn = 0,
        [pbr::OriginalName("STORAGE")] Storage = 1,
        [pbr::OriginalName("RESTRICTED")] Restricted = 3,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
