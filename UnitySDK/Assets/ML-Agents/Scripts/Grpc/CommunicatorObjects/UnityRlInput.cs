// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: mlagents/envs/communicator_objects/unity_rl_input.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MLAgents.CommunicatorObjects {

  /// <summary>Holder for reflection information generated from mlagents/envs/communicator_objects/unity_rl_input.proto</summary>
  public static partial class UnityRlInputReflection {

    #region Descriptor
    /// <summary>File descriptor for mlagents/envs/communicator_objects/unity_rl_input.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static UnityRlInputReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjdtbGFnZW50cy9lbnZzL2NvbW11bmljYXRvcl9vYmplY3RzL3VuaXR5X3Js",
            "X2lucHV0LnByb3RvEhRjb21tdW5pY2F0b3Jfb2JqZWN0cxo1bWxhZ2VudHMv",
            "ZW52cy9jb21tdW5pY2F0b3Jfb2JqZWN0cy9hZ2VudF9hY3Rpb24ucHJvdG8a",
            "P21sYWdlbnRzL2VudnMvY29tbXVuaWNhdG9yX29iamVjdHMvZW52aXJvbm1l",
            "bnRfcGFyYW1ldGVycy5wcm90bxowbWxhZ2VudHMvZW52cy9jb21tdW5pY2F0",
            "b3Jfb2JqZWN0cy9jb21tYW5kLnByb3RvIsMDChFVbml0eVJMSW5wdXRQcm90",
            "bxJQCg1hZ2VudF9hY3Rpb25zGAEgAygLMjkuY29tbXVuaWNhdG9yX29iamVj",
            "dHMuVW5pdHlSTElucHV0UHJvdG8uQWdlbnRBY3Rpb25zRW50cnkSUAoWZW52",
            "aXJvbm1lbnRfcGFyYW1ldGVycxgCIAEoCzIwLmNvbW11bmljYXRvcl9vYmpl",
            "Y3RzLkVudmlyb25tZW50UGFyYW1ldGVyc1Byb3RvEhMKC2lzX3RyYWluaW5n",
            "GAMgASgIEjMKB2NvbW1hbmQYBCABKA4yIi5jb21tdW5pY2F0b3Jfb2JqZWN0",
            "cy5Db21tYW5kUHJvdG8aTQoUTGlzdEFnZW50QWN0aW9uUHJvdG8SNQoFdmFs",
            "dWUYASADKAsyJi5jb21tdW5pY2F0b3Jfb2JqZWN0cy5BZ2VudEFjdGlvblBy",
            "b3RvGnEKEUFnZW50QWN0aW9uc0VudHJ5EgsKA2tleRgBIAEoCRJLCgV2YWx1",
            "ZRgCIAEoCzI8LmNvbW11bmljYXRvcl9vYmplY3RzLlVuaXR5UkxJbnB1dFBy",
            "b3RvLkxpc3RBZ2VudEFjdGlvblByb3RvOgI4AUIfqgIcTUxBZ2VudHMuQ29t",
            "bXVuaWNhdG9yT2JqZWN0c2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::MLAgents.CommunicatorObjects.AgentActionReflection.Descriptor, global::MLAgents.CommunicatorObjects.EnvironmentParametersReflection.Descriptor, global::MLAgents.CommunicatorObjects.CommandReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MLAgents.CommunicatorObjects.UnityRLInputProto), global::MLAgents.CommunicatorObjects.UnityRLInputProto.Parser, new[]{ "AgentActions", "EnvironmentParameters", "IsTraining", "Command" }, null, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::MLAgents.CommunicatorObjects.UnityRLInputProto.Types.ListAgentActionProto), global::MLAgents.CommunicatorObjects.UnityRLInputProto.Types.ListAgentActionProto.Parser, new[]{ "Value" }, null, null, null),
            null, })
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class UnityRLInputProto : pb::IMessage<UnityRLInputProto> {
    private static readonly pb::MessageParser<UnityRLInputProto> _parser = new pb::MessageParser<UnityRLInputProto>(() => new UnityRLInputProto());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<UnityRLInputProto> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MLAgents.CommunicatorObjects.UnityRlInputReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UnityRLInputProto() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UnityRLInputProto(UnityRLInputProto other) : this() {
      agentActions_ = other.agentActions_.Clone();
      EnvironmentParameters = other.environmentParameters_ != null ? other.EnvironmentParameters.Clone() : null;
      isTraining_ = other.isTraining_;
      command_ = other.command_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UnityRLInputProto Clone() {
      return new UnityRLInputProto(this);
    }

    /// <summary>Field number for the "agent_actions" field.</summary>
    public const int AgentActionsFieldNumber = 1;
    private static readonly pbc::MapField<string, global::MLAgents.CommunicatorObjects.UnityRLInputProto.Types.ListAgentActionProto>.Codec _map_agentActions_codec
        = new pbc::MapField<string, global::MLAgents.CommunicatorObjects.UnityRLInputProto.Types.ListAgentActionProto>.Codec(pb::FieldCodec.ForString(10), pb::FieldCodec.ForMessage(18, global::MLAgents.CommunicatorObjects.UnityRLInputProto.Types.ListAgentActionProto.Parser), 10);
    private readonly pbc::MapField<string, global::MLAgents.CommunicatorObjects.UnityRLInputProto.Types.ListAgentActionProto> agentActions_ = new pbc::MapField<string, global::MLAgents.CommunicatorObjects.UnityRLInputProto.Types.ListAgentActionProto>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<string, global::MLAgents.CommunicatorObjects.UnityRLInputProto.Types.ListAgentActionProto> AgentActions {
      get { return agentActions_; }
    }

    /// <summary>Field number for the "environment_parameters" field.</summary>
    public const int EnvironmentParametersFieldNumber = 2;
    private global::MLAgents.CommunicatorObjects.EnvironmentParametersProto environmentParameters_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::MLAgents.CommunicatorObjects.EnvironmentParametersProto EnvironmentParameters {
      get { return environmentParameters_; }
      set {
        environmentParameters_ = value;
      }
    }

    /// <summary>Field number for the "is_training" field.</summary>
    public const int IsTrainingFieldNumber = 3;
    private bool isTraining_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool IsTraining {
      get { return isTraining_; }
      set {
        isTraining_ = value;
      }
    }

    /// <summary>Field number for the "command" field.</summary>
    public const int CommandFieldNumber = 4;
    private global::MLAgents.CommunicatorObjects.CommandProto command_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::MLAgents.CommunicatorObjects.CommandProto Command {
      get { return command_; }
      set {
        command_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as UnityRLInputProto);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(UnityRLInputProto other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!AgentActions.Equals(other.AgentActions)) return false;
      if (!object.Equals(EnvironmentParameters, other.EnvironmentParameters)) return false;
      if (IsTraining != other.IsTraining) return false;
      if (Command != other.Command) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= AgentActions.GetHashCode();
      if (environmentParameters_ != null) hash ^= EnvironmentParameters.GetHashCode();
      if (IsTraining != false) hash ^= IsTraining.GetHashCode();
      if (Command != 0) hash ^= Command.GetHashCode();
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
      agentActions_.WriteTo(output, _map_agentActions_codec);
      if (environmentParameters_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(EnvironmentParameters);
      }
      if (IsTraining != false) {
        output.WriteRawTag(24);
        output.WriteBool(IsTraining);
      }
      if (Command != 0) {
        output.WriteRawTag(32);
        output.WriteEnum((int) Command);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += agentActions_.CalculateSize(_map_agentActions_codec);
      if (environmentParameters_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(EnvironmentParameters);
      }
      if (IsTraining != false) {
        size += 1 + 1;
      }
      if (Command != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Command);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(UnityRLInputProto other) {
      if (other == null) {
        return;
      }
      agentActions_.Add(other.agentActions_);
      if (other.environmentParameters_ != null) {
        if (environmentParameters_ == null) {
          environmentParameters_ = new global::MLAgents.CommunicatorObjects.EnvironmentParametersProto();
        }
        EnvironmentParameters.MergeFrom(other.EnvironmentParameters);
      }
      if (other.IsTraining != false) {
        IsTraining = other.IsTraining;
      }
      if (other.Command != 0) {
        Command = other.Command;
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
            agentActions_.AddEntriesFrom(input, _map_agentActions_codec);
            break;
          }
          case 18: {
            if (environmentParameters_ == null) {
              environmentParameters_ = new global::MLAgents.CommunicatorObjects.EnvironmentParametersProto();
            }
            input.ReadMessage(environmentParameters_);
            break;
          }
          case 24: {
            IsTraining = input.ReadBool();
            break;
          }
          case 32: {
            command_ = (global::MLAgents.CommunicatorObjects.CommandProto) input.ReadEnum();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the UnityRLInputProto message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public sealed partial class ListAgentActionProto : pb::IMessage<ListAgentActionProto> {
        private static readonly pb::MessageParser<ListAgentActionProto> _parser = new pb::MessageParser<ListAgentActionProto>(() => new ListAgentActionProto());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<ListAgentActionProto> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::MLAgents.CommunicatorObjects.UnityRLInputProto.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public ListAgentActionProto() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public ListAgentActionProto(ListAgentActionProto other) : this() {
          value_ = other.value_.Clone();
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public ListAgentActionProto Clone() {
          return new ListAgentActionProto(this);
        }

        /// <summary>Field number for the "value" field.</summary>
        public const int ValueFieldNumber = 1;
        private static readonly pb::FieldCodec<global::MLAgents.CommunicatorObjects.AgentActionProto> _repeated_value_codec
            = pb::FieldCodec.ForMessage(10, global::MLAgents.CommunicatorObjects.AgentActionProto.Parser);
        private readonly pbc::RepeatedField<global::MLAgents.CommunicatorObjects.AgentActionProto> value_ = new pbc::RepeatedField<global::MLAgents.CommunicatorObjects.AgentActionProto>();
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public pbc::RepeatedField<global::MLAgents.CommunicatorObjects.AgentActionProto> Value {
          get { return value_; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other) {
          return Equals(other as ListAgentActionProto);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(ListAgentActionProto other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if(!value_.Equals(other.value_)) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode() {
          int hash = 1;
          hash ^= value_.GetHashCode();
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
          value_.WriteTo(output, _repeated_value_codec);
          if (_unknownFields != null) {
            _unknownFields.WriteTo(output);
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize() {
          int size = 0;
          size += value_.CalculateSize(_repeated_value_codec);
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(ListAgentActionProto other) {
          if (other == null) {
            return;
          }
          value_.Add(other.value_);
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
                value_.AddEntriesFrom(input, _repeated_value_codec);
                break;
              }
            }
          }
        }

      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code