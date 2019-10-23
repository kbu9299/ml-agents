// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: mlagents/envs/communicator_objects/agent_info.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MLAgents.CommunicatorObjects {

  /// <summary>Holder for reflection information generated from mlagents/envs/communicator_objects/agent_info.proto</summary>
  public static partial class AgentInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for mlagents/envs/communicator_objects/agent_info.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AgentInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjNtbGFnZW50cy9lbnZzL2NvbW11bmljYXRvcl9vYmplY3RzL2FnZW50X2lu",
            "Zm8ucHJvdG8SFGNvbW11bmljYXRvcl9vYmplY3RzGj9tbGFnZW50cy9lbnZz",
            "L2NvbW11bmljYXRvcl9vYmplY3RzL2NvbXByZXNzZWRfb2JzZXJ2YXRpb24u",
            "cHJvdG8aO21sYWdlbnRzL2VudnMvY29tbXVuaWNhdG9yX29iamVjdHMvY3Vz",
            "dG9tX29ic2VydmF0aW9uLnByb3RvIqkDCg5BZ2VudEluZm9Qcm90bxIiChpz",
            "dGFja2VkX3ZlY3Rvcl9vYnNlcnZhdGlvbhgBIAMoAhIYChB0ZXh0X29ic2Vy",
            "dmF0aW9uGAMgASgJEh0KFXN0b3JlZF92ZWN0b3JfYWN0aW9ucxgEIAMoAhIb",
            "ChNzdG9yZWRfdGV4dF9hY3Rpb25zGAUgASgJEhAKCG1lbW9yaWVzGAYgAygC",
            "Eg4KBnJld2FyZBgHIAEoAhIMCgRkb25lGAggASgIEhgKEG1heF9zdGVwX3Jl",
            "YWNoZWQYCSABKAgSCgoCaWQYCiABKAUSDwoHdGVhbV9pZBgLIAEoBRITCgth",
            "Y3Rpb25fbWFzaxgMIAMoCBJIChJjdXN0b21fb2JzZXJ2YXRpb24YDSABKAsy",
            "LC5jb21tdW5pY2F0b3Jfb2JqZWN0cy5DdXN0b21PYnNlcnZhdGlvblByb3Rv",
            "ElEKF2NvbXByZXNzZWRfb2JzZXJ2YXRpb25zGA4gAygLMjAuY29tbXVuaWNh",
            "dG9yX29iamVjdHMuQ29tcHJlc3NlZE9ic2VydmF0aW9uUHJvdG9KBAgCEANC",
            "H6oCHE1MQWdlbnRzLkNvbW11bmljYXRvck9iamVjdHNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::MLAgents.CommunicatorObjects.CompressedObservationReflection.Descriptor, global::MLAgents.CommunicatorObjects.CustomObservationReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MLAgents.CommunicatorObjects.AgentInfoProto), global::MLAgents.CommunicatorObjects.AgentInfoProto.Parser, new[]{ "StackedVectorObservation", "TextObservation", "StoredVectorActions", "StoredTextActions", "Memories", "Reward", "Done", "MaxStepReached", "Id", "TeamId", "ActionMask", "CustomObservation", "CompressedObservations" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class AgentInfoProto : pb::IMessage<AgentInfoProto> {
    private static readonly pb::MessageParser<AgentInfoProto> _parser = new pb::MessageParser<AgentInfoProto>(() => new AgentInfoProto());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AgentInfoProto> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MLAgents.CommunicatorObjects.AgentInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AgentInfoProto() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AgentInfoProto(AgentInfoProto other) : this() {
      stackedVectorObservation_ = other.stackedVectorObservation_.Clone();
      textObservation_ = other.textObservation_;
      storedVectorActions_ = other.storedVectorActions_.Clone();
      storedTextActions_ = other.storedTextActions_;
      memories_ = other.memories_.Clone();
      reward_ = other.reward_;
      done_ = other.done_;
      maxStepReached_ = other.maxStepReached_;
      id_ = other.id_;
      teamId_ = other.teamId_;
      actionMask_ = other.actionMask_.Clone();
      CustomObservation = other.customObservation_ != null ? other.CustomObservation.Clone() : null;
      compressedObservations_ = other.compressedObservations_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AgentInfoProto Clone() {
      return new AgentInfoProto(this);
    }

    /// <summary>Field number for the "stacked_vector_observation" field.</summary>
    public const int StackedVectorObservationFieldNumber = 1;
    private static readonly pb::FieldCodec<float> _repeated_stackedVectorObservation_codec
        = pb::FieldCodec.ForFloat(10);
    private readonly pbc::RepeatedField<float> stackedVectorObservation_ = new pbc::RepeatedField<float>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<float> StackedVectorObservation {
      get { return stackedVectorObservation_; }
    }

    /// <summary>Field number for the "text_observation" field.</summary>
    public const int TextObservationFieldNumber = 3;
    private string textObservation_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string TextObservation {
      get { return textObservation_; }
      set {
        textObservation_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "stored_vector_actions" field.</summary>
    public const int StoredVectorActionsFieldNumber = 4;
    private static readonly pb::FieldCodec<float> _repeated_storedVectorActions_codec
        = pb::FieldCodec.ForFloat(34);
    private readonly pbc::RepeatedField<float> storedVectorActions_ = new pbc::RepeatedField<float>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<float> StoredVectorActions {
      get { return storedVectorActions_; }
    }

    /// <summary>Field number for the "stored_text_actions" field.</summary>
    public const int StoredTextActionsFieldNumber = 5;
    private string storedTextActions_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string StoredTextActions {
      get { return storedTextActions_; }
      set {
        storedTextActions_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "memories" field.</summary>
    public const int MemoriesFieldNumber = 6;
    private static readonly pb::FieldCodec<float> _repeated_memories_codec
        = pb::FieldCodec.ForFloat(50);
    private readonly pbc::RepeatedField<float> memories_ = new pbc::RepeatedField<float>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<float> Memories {
      get { return memories_; }
    }

    /// <summary>Field number for the "reward" field.</summary>
    public const int RewardFieldNumber = 7;
    private float reward_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float Reward {
      get { return reward_; }
      set {
        reward_ = value;
      }
    }

    /// <summary>Field number for the "done" field.</summary>
    public const int DoneFieldNumber = 8;
    private bool done_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Done {
      get { return done_; }
      set {
        done_ = value;
      }
    }

    /// <summary>Field number for the "max_step_reached" field.</summary>
    public const int MaxStepReachedFieldNumber = 9;
    private bool maxStepReached_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool MaxStepReached {
      get { return maxStepReached_; }
      set {
        maxStepReached_ = value;
      }
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 10;
    private int id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    /// <summary>Field number for the "team_id" field.</summary>
    public const int TeamIdFieldNumber = 11;
    private int teamId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int TeamId {
      get { return teamId_; }
      set {
        teamId_ = value;
      }
    }

    /// <summary>Field number for the "action_mask" field.</summary>
    public const int ActionMaskFieldNumber = 12;
    private static readonly pb::FieldCodec<bool> _repeated_actionMask_codec
        = pb::FieldCodec.ForBool(98);
    private readonly pbc::RepeatedField<bool> actionMask_ = new pbc::RepeatedField<bool>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<bool> ActionMask {
      get { return actionMask_; }
    }

    /// <summary>Field number for the "custom_observation" field.</summary>
    public const int CustomObservationFieldNumber = 13;
    private global::MLAgents.CommunicatorObjects.CustomObservationProto customObservation_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::MLAgents.CommunicatorObjects.CustomObservationProto CustomObservation {
      get { return customObservation_; }
      set {
        customObservation_ = value;
      }
    }

    /// <summary>Field number for the "compressed_observations" field.</summary>
    public const int CompressedObservationsFieldNumber = 14;
    private static readonly pb::FieldCodec<global::MLAgents.CommunicatorObjects.CompressedObservationProto> _repeated_compressedObservations_codec
        = pb::FieldCodec.ForMessage(114, global::MLAgents.CommunicatorObjects.CompressedObservationProto.Parser);
    private readonly pbc::RepeatedField<global::MLAgents.CommunicatorObjects.CompressedObservationProto> compressedObservations_ = new pbc::RepeatedField<global::MLAgents.CommunicatorObjects.CompressedObservationProto>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::MLAgents.CommunicatorObjects.CompressedObservationProto> CompressedObservations {
      get { return compressedObservations_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AgentInfoProto);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AgentInfoProto other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!stackedVectorObservation_.Equals(other.stackedVectorObservation_)) return false;
      if (TextObservation != other.TextObservation) return false;
      if(!storedVectorActions_.Equals(other.storedVectorActions_)) return false;
      if (StoredTextActions != other.StoredTextActions) return false;
      if(!memories_.Equals(other.memories_)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Reward, other.Reward)) return false;
      if (Done != other.Done) return false;
      if (MaxStepReached != other.MaxStepReached) return false;
      if (Id != other.Id) return false;
      if (TeamId != other.TeamId) return false;
      if(!actionMask_.Equals(other.actionMask_)) return false;
      if (!object.Equals(CustomObservation, other.CustomObservation)) return false;
      if(!compressedObservations_.Equals(other.compressedObservations_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= stackedVectorObservation_.GetHashCode();
      if (TextObservation.Length != 0) hash ^= TextObservation.GetHashCode();
      hash ^= storedVectorActions_.GetHashCode();
      if (StoredTextActions.Length != 0) hash ^= StoredTextActions.GetHashCode();
      hash ^= memories_.GetHashCode();
      if (Reward != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Reward);
      if (Done != false) hash ^= Done.GetHashCode();
      if (MaxStepReached != false) hash ^= MaxStepReached.GetHashCode();
      if (Id != 0) hash ^= Id.GetHashCode();
      if (TeamId != 0) hash ^= TeamId.GetHashCode();
      hash ^= actionMask_.GetHashCode();
      if (customObservation_ != null) hash ^= CustomObservation.GetHashCode();
      hash ^= compressedObservations_.GetHashCode();
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
      stackedVectorObservation_.WriteTo(output, _repeated_stackedVectorObservation_codec);
      if (TextObservation.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(TextObservation);
      }
      storedVectorActions_.WriteTo(output, _repeated_storedVectorActions_codec);
      if (StoredTextActions.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(StoredTextActions);
      }
      memories_.WriteTo(output, _repeated_memories_codec);
      if (Reward != 0F) {
        output.WriteRawTag(61);
        output.WriteFloat(Reward);
      }
      if (Done != false) {
        output.WriteRawTag(64);
        output.WriteBool(Done);
      }
      if (MaxStepReached != false) {
        output.WriteRawTag(72);
        output.WriteBool(MaxStepReached);
      }
      if (Id != 0) {
        output.WriteRawTag(80);
        output.WriteInt32(Id);
      }
      if (TeamId != 0) {
        output.WriteRawTag(88);
        output.WriteInt32(TeamId);
      }
      actionMask_.WriteTo(output, _repeated_actionMask_codec);
      if (customObservation_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(CustomObservation);
      }
      compressedObservations_.WriteTo(output, _repeated_compressedObservations_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += stackedVectorObservation_.CalculateSize(_repeated_stackedVectorObservation_codec);
      if (TextObservation.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(TextObservation);
      }
      size += storedVectorActions_.CalculateSize(_repeated_storedVectorActions_codec);
      if (StoredTextActions.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(StoredTextActions);
      }
      size += memories_.CalculateSize(_repeated_memories_codec);
      if (Reward != 0F) {
        size += 1 + 4;
      }
      if (Done != false) {
        size += 1 + 1;
      }
      if (MaxStepReached != false) {
        size += 1 + 1;
      }
      if (Id != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Id);
      }
      if (TeamId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(TeamId);
      }
      size += actionMask_.CalculateSize(_repeated_actionMask_codec);
      if (customObservation_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CustomObservation);
      }
      size += compressedObservations_.CalculateSize(_repeated_compressedObservations_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(AgentInfoProto other) {
      if (other == null) {
        return;
      }
      stackedVectorObservation_.Add(other.stackedVectorObservation_);
      if (other.TextObservation.Length != 0) {
        TextObservation = other.TextObservation;
      }
      storedVectorActions_.Add(other.storedVectorActions_);
      if (other.StoredTextActions.Length != 0) {
        StoredTextActions = other.StoredTextActions;
      }
      memories_.Add(other.memories_);
      if (other.Reward != 0F) {
        Reward = other.Reward;
      }
      if (other.Done != false) {
        Done = other.Done;
      }
      if (other.MaxStepReached != false) {
        MaxStepReached = other.MaxStepReached;
      }
      if (other.Id != 0) {
        Id = other.Id;
      }
      if (other.TeamId != 0) {
        TeamId = other.TeamId;
      }
      actionMask_.Add(other.actionMask_);
      if (other.customObservation_ != null) {
        if (customObservation_ == null) {
          customObservation_ = new global::MLAgents.CommunicatorObjects.CustomObservationProto();
        }
        CustomObservation.MergeFrom(other.CustomObservation);
      }
      compressedObservations_.Add(other.compressedObservations_);
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
          case 13: {
            stackedVectorObservation_.AddEntriesFrom(input, _repeated_stackedVectorObservation_codec);
            break;
          }
          case 26: {
            TextObservation = input.ReadString();
            break;
          }
          case 34:
          case 37: {
            storedVectorActions_.AddEntriesFrom(input, _repeated_storedVectorActions_codec);
            break;
          }
          case 42: {
            StoredTextActions = input.ReadString();
            break;
          }
          case 50:
          case 53: {
            memories_.AddEntriesFrom(input, _repeated_memories_codec);
            break;
          }
          case 61: {
            Reward = input.ReadFloat();
            break;
          }
          case 64: {
            Done = input.ReadBool();
            break;
          }
          case 72: {
            MaxStepReached = input.ReadBool();
            break;
          }
          case 80: {
            Id = input.ReadInt32();
            break;
          }
          case 88: {
            TeamId = input.ReadInt32();
            break;
          }
          case 98:
          case 96: {
            actionMask_.AddEntriesFrom(input, _repeated_actionMask_codec);
            break;
          }
          case 106: {
            if (customObservation_ == null) {
              customObservation_ = new global::MLAgents.CommunicatorObjects.CustomObservationProto();
            }
            input.ReadMessage(customObservation_);
            break;
          }
          case 114: {
            compressedObservations_.AddEntriesFrom(input, _repeated_compressedObservations_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
