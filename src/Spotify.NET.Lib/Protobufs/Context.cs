// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: context.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace CPlayerLib.Player.Proto {

  /// <summary>Holder for reflection information generated from context.proto</summary>
  public static partial class ContextReflection {

    #region Descriptor
    /// <summary>File descriptor for context.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ContextReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cg1jb250ZXh0LnByb3RvEhRzcG90aWZ5LnBsYXllci5wcm90bxoSY29udGV4",
            "dF9wYWdlLnByb3RvGhJyZXN0cmljdGlvbnMucHJvdG8ikAIKB0NvbnRleHQS",
            "CwoDdXJpGAEgASgJEgsKA3VybBgCIAEoCRI9CghtZXRhZGF0YRgDIAMoCzIr",
            "LnNwb3RpZnkucGxheWVyLnByb3RvLkNvbnRleHQuTWV0YWRhdGFFbnRyeRI4",
            "CgxyZXN0cmljdGlvbnMYBCABKAsyIi5zcG90aWZ5LnBsYXllci5wcm90by5S",
            "ZXN0cmljdGlvbnMSMAoFcGFnZXMYBSADKAsyIS5zcG90aWZ5LnBsYXllci5w",
            "cm90by5Db250ZXh0UGFnZRIPCgdsb2FkaW5nGAYgASgIGi8KDU1ldGFkYXRh",
            "RW50cnkSCwoDa2V5GAEgASgJEg0KBXZhbHVlGAIgASgJOgI4AUIXChNjb20u",
            "c3BvdGlmeS5jb250ZXh0SAI="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::CPlayerLib.Player.Proto.ContextPageReflection.Descriptor, global::CPlayerLib.Player.Proto.RestrictionsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::CPlayerLib.Player.Proto.Context), global::CPlayerLib.Player.Proto.Context.Parser, new[]{ "Uri", "Url", "Metadata", "Restrictions", "Pages", "Loading" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Context : pb::IMessage<Context>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Context> _parser = new pb::MessageParser<Context>(() => new Context());
    private pb::UnknownFieldSet _unknownFields;
    private int _hasBits0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Context> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::CPlayerLib.Player.Proto.ContextReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Context() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Context(Context other) : this() {
      _hasBits0 = other._hasBits0;
      uri_ = other.uri_;
      url_ = other.url_;
      metadata_ = other.metadata_.Clone();
      restrictions_ = other.restrictions_ != null ? other.restrictions_.Clone() : null;
      pages_ = other.pages_.Clone();
      loading_ = other.loading_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Context Clone() {
      return new Context(this);
    }

    /// <summary>Field number for the "uri" field.</summary>
    public const int UriFieldNumber = 1;
    private readonly static string UriDefaultValue = "";

    private string uri_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Uri {
      get { return uri_ ?? UriDefaultValue; }
      set {
        uri_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "uri" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HasUri {
      get { return uri_ != null; }
    }
    /// <summary>Clears the value of the "uri" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearUri() {
      uri_ = null;
    }

    /// <summary>Field number for the "url" field.</summary>
    public const int UrlFieldNumber = 2;
    private readonly static string UrlDefaultValue = "";

    private string url_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Url {
      get { return url_ ?? UrlDefaultValue; }
      set {
        url_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "url" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HasUrl {
      get { return url_ != null; }
    }
    /// <summary>Clears the value of the "url" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearUrl() {
      url_ = null;
    }

    /// <summary>Field number for the "metadata" field.</summary>
    public const int MetadataFieldNumber = 3;
    private static readonly pbc::MapField<string, string>.Codec _map_metadata_codec
        = new pbc::MapField<string, string>.Codec(pb::FieldCodec.ForString(10, ""), pb::FieldCodec.ForString(18, ""), 26);
    private readonly pbc::MapField<string, string> metadata_ = new pbc::MapField<string, string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<string, string> Metadata {
      get { return metadata_; }
    }

    /// <summary>Field number for the "restrictions" field.</summary>
    public const int RestrictionsFieldNumber = 4;
    private global::CPlayerLib.Player.Proto.Restrictions restrictions_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::CPlayerLib.Player.Proto.Restrictions Restrictions {
      get { return restrictions_; }
      set {
        restrictions_ = value;
      }
    }

    /// <summary>Field number for the "pages" field.</summary>
    public const int PagesFieldNumber = 5;
    private static readonly pb::FieldCodec<global::CPlayerLib.Player.Proto.ContextPage> _repeated_pages_codec
        = pb::FieldCodec.ForMessage(42, global::CPlayerLib.Player.Proto.ContextPage.Parser);
    private readonly pbc::RepeatedField<global::CPlayerLib.Player.Proto.ContextPage> pages_ = new pbc::RepeatedField<global::CPlayerLib.Player.Proto.ContextPage>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::CPlayerLib.Player.Proto.ContextPage> Pages {
      get { return pages_; }
    }

    /// <summary>Field number for the "loading" field.</summary>
    public const int LoadingFieldNumber = 6;
    private readonly static bool LoadingDefaultValue = false;

    private bool loading_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Loading {
      get { if ((_hasBits0 & 1) != 0) { return loading_; } else { return LoadingDefaultValue; } }
      set {
        _hasBits0 |= 1;
        loading_ = value;
      }
    }
    /// <summary>Gets whether the "loading" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HasLoading {
      get { return (_hasBits0 & 1) != 0; }
    }
    /// <summary>Clears the value of the "loading" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearLoading() {
      _hasBits0 &= ~1;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Context);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Context other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Uri != other.Uri) return false;
      if (Url != other.Url) return false;
      if (!Metadata.Equals(other.Metadata)) return false;
      if (!object.Equals(Restrictions, other.Restrictions)) return false;
      if(!pages_.Equals(other.pages_)) return false;
      if (Loading != other.Loading) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (HasUri) hash ^= Uri.GetHashCode();
      if (HasUrl) hash ^= Url.GetHashCode();
      hash ^= Metadata.GetHashCode();
      if (restrictions_ != null) hash ^= Restrictions.GetHashCode();
      hash ^= pages_.GetHashCode();
      if (HasLoading) hash ^= Loading.GetHashCode();
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
      if (HasUri) {
        output.WriteRawTag(10);
        output.WriteString(Uri);
      }
      if (HasUrl) {
        output.WriteRawTag(18);
        output.WriteString(Url);
      }
      metadata_.WriteTo(output, _map_metadata_codec);
      if (restrictions_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(Restrictions);
      }
      pages_.WriteTo(output, _repeated_pages_codec);
      if (HasLoading) {
        output.WriteRawTag(48);
        output.WriteBool(Loading);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (HasUri) {
        output.WriteRawTag(10);
        output.WriteString(Uri);
      }
      if (HasUrl) {
        output.WriteRawTag(18);
        output.WriteString(Url);
      }
      metadata_.WriteTo(ref output, _map_metadata_codec);
      if (restrictions_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(Restrictions);
      }
      pages_.WriteTo(ref output, _repeated_pages_codec);
      if (HasLoading) {
        output.WriteRawTag(48);
        output.WriteBool(Loading);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (HasUri) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Uri);
      }
      if (HasUrl) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Url);
      }
      size += metadata_.CalculateSize(_map_metadata_codec);
      if (restrictions_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Restrictions);
      }
      size += pages_.CalculateSize(_repeated_pages_codec);
      if (HasLoading) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Context other) {
      if (other == null) {
        return;
      }
      if (other.HasUri) {
        Uri = other.Uri;
      }
      if (other.HasUrl) {
        Url = other.Url;
      }
      metadata_.Add(other.metadata_);
      if (other.restrictions_ != null) {
        if (restrictions_ == null) {
          Restrictions = new global::CPlayerLib.Player.Proto.Restrictions();
        }
        Restrictions.MergeFrom(other.Restrictions);
      }
      pages_.Add(other.pages_);
      if (other.HasLoading) {
        Loading = other.Loading;
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
            Uri = input.ReadString();
            break;
          }
          case 18: {
            Url = input.ReadString();
            break;
          }
          case 26: {
            metadata_.AddEntriesFrom(input, _map_metadata_codec);
            break;
          }
          case 34: {
            if (restrictions_ == null) {
              Restrictions = new global::CPlayerLib.Player.Proto.Restrictions();
            }
            input.ReadMessage(Restrictions);
            break;
          }
          case 42: {
            pages_.AddEntriesFrom(input, _repeated_pages_codec);
            break;
          }
          case 48: {
            Loading = input.ReadBool();
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
            Uri = input.ReadString();
            break;
          }
          case 18: {
            Url = input.ReadString();
            break;
          }
          case 26: {
            metadata_.AddEntriesFrom(ref input, _map_metadata_codec);
            break;
          }
          case 34: {
            if (restrictions_ == null) {
              Restrictions = new global::CPlayerLib.Player.Proto.Restrictions();
            }
            input.ReadMessage(Restrictions);
            break;
          }
          case 42: {
            pages_.AddEntriesFrom(ref input, _repeated_pages_codec);
            break;
          }
          case 48: {
            Loading = input.ReadBool();
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
