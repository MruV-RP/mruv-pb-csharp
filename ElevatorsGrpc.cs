// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: elevators/elevators.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Mruv.Elevators {
  /// <summary>
  /// The MruV entrances service provides procedures for managing an elevators.
  /// Elevators allow all players in the elevator area to move between building floors.
  /// Floor change is processed in following steps:
  /// 1. Someone chooses a floor
  /// 1. Doors closing event is fired
  /// 2. Doors closed event is fired.
  /// 3. Everyone in a elevator are registered as players, that will be teleported to chosen floor.
  /// 4. X seconds delay (elevator is moving)
  /// 5. Teleport players to other floor elevator
  /// 6. Doors opening
  /// 7. Doors opened - end
  /// You can define a one-man pseudo-elevator where only point 5 is executed.
  /// </summary>
  public static partial class MruVElevatorsService
  {
    static readonly string __ServiceName = "mruv.elevators.MruVElevatorsService";

    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    static readonly grpc::Marshaller<global::Mruv.Elevators.CreateElevatorRequest> __Marshaller_mruv_elevators_CreateElevatorRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Mruv.Elevators.CreateElevatorRequest.Parser));
    static readonly grpc::Marshaller<global::Mruv.Elevators.CreateElevatorResponse> __Marshaller_mruv_elevators_CreateElevatorResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Mruv.Elevators.CreateElevatorResponse.Parser));
    static readonly grpc::Marshaller<global::Mruv.Elevators.GetElevatorRequest> __Marshaller_mruv_elevators_GetElevatorRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Mruv.Elevators.GetElevatorRequest.Parser));
    static readonly grpc::Marshaller<global::Mruv.Elevators.GetElevatorResponse> __Marshaller_mruv_elevators_GetElevatorResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Mruv.Elevators.GetElevatorResponse.Parser));
    static readonly grpc::Marshaller<global::Mruv.Elevators.UpdateElevatorRequest> __Marshaller_mruv_elevators_UpdateElevatorRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Mruv.Elevators.UpdateElevatorRequest.Parser));
    static readonly grpc::Marshaller<global::Mruv.Elevators.UpdateElevatorResponse> __Marshaller_mruv_elevators_UpdateElevatorResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Mruv.Elevators.UpdateElevatorResponse.Parser));
    static readonly grpc::Marshaller<global::Mruv.Elevators.DeleteElevatorRequest> __Marshaller_mruv_elevators_DeleteElevatorRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Mruv.Elevators.DeleteElevatorRequest.Parser));
    static readonly grpc::Marshaller<global::Mruv.Elevators.DeleteElevatorResponse> __Marshaller_mruv_elevators_DeleteElevatorResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Mruv.Elevators.DeleteElevatorResponse.Parser));
    static readonly grpc::Marshaller<global::Mruv.Elevators.GetElevatorFloorsRequest> __Marshaller_mruv_elevators_GetElevatorFloorsRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Mruv.Elevators.GetElevatorFloorsRequest.Parser));
    static readonly grpc::Marshaller<global::Mruv.Elevators.GetElevatorFloorsResponse> __Marshaller_mruv_elevators_GetElevatorFloorsResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Mruv.Elevators.GetElevatorFloorsResponse.Parser));

    static readonly grpc::Method<global::Mruv.Elevators.CreateElevatorRequest, global::Mruv.Elevators.CreateElevatorResponse> __Method_CreateElevator = new grpc::Method<global::Mruv.Elevators.CreateElevatorRequest, global::Mruv.Elevators.CreateElevatorResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CreateElevator",
        __Marshaller_mruv_elevators_CreateElevatorRequest,
        __Marshaller_mruv_elevators_CreateElevatorResponse);

    static readonly grpc::Method<global::Mruv.Elevators.GetElevatorRequest, global::Mruv.Elevators.GetElevatorResponse> __Method_GetElevator = new grpc::Method<global::Mruv.Elevators.GetElevatorRequest, global::Mruv.Elevators.GetElevatorResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetElevator",
        __Marshaller_mruv_elevators_GetElevatorRequest,
        __Marshaller_mruv_elevators_GetElevatorResponse);

    static readonly grpc::Method<global::Mruv.Elevators.UpdateElevatorRequest, global::Mruv.Elevators.UpdateElevatorResponse> __Method_UpdateElevator = new grpc::Method<global::Mruv.Elevators.UpdateElevatorRequest, global::Mruv.Elevators.UpdateElevatorResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UpdateElevator",
        __Marshaller_mruv_elevators_UpdateElevatorRequest,
        __Marshaller_mruv_elevators_UpdateElevatorResponse);

    static readonly grpc::Method<global::Mruv.Elevators.DeleteElevatorRequest, global::Mruv.Elevators.DeleteElevatorResponse> __Method_DeleteElevator = new grpc::Method<global::Mruv.Elevators.DeleteElevatorRequest, global::Mruv.Elevators.DeleteElevatorResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeleteElevator",
        __Marshaller_mruv_elevators_DeleteElevatorRequest,
        __Marshaller_mruv_elevators_DeleteElevatorResponse);

    static readonly grpc::Method<global::Mruv.Elevators.GetElevatorFloorsRequest, global::Mruv.Elevators.GetElevatorFloorsResponse> __Method_GetElevatorFloors = new grpc::Method<global::Mruv.Elevators.GetElevatorFloorsRequest, global::Mruv.Elevators.GetElevatorFloorsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetElevatorFloors",
        __Marshaller_mruv_elevators_GetElevatorFloorsRequest,
        __Marshaller_mruv_elevators_GetElevatorFloorsResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Mruv.Elevators.ElevatorsReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of MruVElevatorsService</summary>
    [grpc::BindServiceMethod(typeof(MruVElevatorsService), "BindService")]
    public abstract partial class MruVElevatorsServiceBase
    {
      /// <summary>
      /// Create an elevator.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Mruv.Elevators.CreateElevatorResponse> CreateElevator(global::Mruv.Elevators.CreateElevatorRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Get an elevator.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Mruv.Elevators.GetElevatorResponse> GetElevator(global::Mruv.Elevators.GetElevatorRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Update an elevator.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Mruv.Elevators.UpdateElevatorResponse> UpdateElevator(global::Mruv.Elevators.UpdateElevatorRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Delete an elevator.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Mruv.Elevators.DeleteElevatorResponse> DeleteElevator(global::Mruv.Elevators.DeleteElevatorRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Get available elevator floors.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Mruv.Elevators.GetElevatorFloorsResponse> GetElevatorFloors(global::Mruv.Elevators.GetElevatorFloorsRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for MruVElevatorsService</summary>
    public partial class MruVElevatorsServiceClient : grpc::ClientBase<MruVElevatorsServiceClient>
    {
      /// <summary>Creates a new client for MruVElevatorsService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public MruVElevatorsServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for MruVElevatorsService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public MruVElevatorsServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected MruVElevatorsServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected MruVElevatorsServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Create an elevator.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Mruv.Elevators.CreateElevatorResponse CreateElevator(global::Mruv.Elevators.CreateElevatorRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateElevator(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Create an elevator.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Mruv.Elevators.CreateElevatorResponse CreateElevator(global::Mruv.Elevators.CreateElevatorRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_CreateElevator, null, options, request);
      }
      /// <summary>
      /// Create an elevator.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Mruv.Elevators.CreateElevatorResponse> CreateElevatorAsync(global::Mruv.Elevators.CreateElevatorRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateElevatorAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Create an elevator.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Mruv.Elevators.CreateElevatorResponse> CreateElevatorAsync(global::Mruv.Elevators.CreateElevatorRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_CreateElevator, null, options, request);
      }
      /// <summary>
      /// Get an elevator.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Mruv.Elevators.GetElevatorResponse GetElevator(global::Mruv.Elevators.GetElevatorRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetElevator(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Get an elevator.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Mruv.Elevators.GetElevatorResponse GetElevator(global::Mruv.Elevators.GetElevatorRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetElevator, null, options, request);
      }
      /// <summary>
      /// Get an elevator.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Mruv.Elevators.GetElevatorResponse> GetElevatorAsync(global::Mruv.Elevators.GetElevatorRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetElevatorAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Get an elevator.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Mruv.Elevators.GetElevatorResponse> GetElevatorAsync(global::Mruv.Elevators.GetElevatorRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetElevator, null, options, request);
      }
      /// <summary>
      /// Update an elevator.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Mruv.Elevators.UpdateElevatorResponse UpdateElevator(global::Mruv.Elevators.UpdateElevatorRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdateElevator(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Update an elevator.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Mruv.Elevators.UpdateElevatorResponse UpdateElevator(global::Mruv.Elevators.UpdateElevatorRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_UpdateElevator, null, options, request);
      }
      /// <summary>
      /// Update an elevator.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Mruv.Elevators.UpdateElevatorResponse> UpdateElevatorAsync(global::Mruv.Elevators.UpdateElevatorRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdateElevatorAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Update an elevator.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Mruv.Elevators.UpdateElevatorResponse> UpdateElevatorAsync(global::Mruv.Elevators.UpdateElevatorRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_UpdateElevator, null, options, request);
      }
      /// <summary>
      /// Delete an elevator.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Mruv.Elevators.DeleteElevatorResponse DeleteElevator(global::Mruv.Elevators.DeleteElevatorRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteElevator(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Delete an elevator.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Mruv.Elevators.DeleteElevatorResponse DeleteElevator(global::Mruv.Elevators.DeleteElevatorRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_DeleteElevator, null, options, request);
      }
      /// <summary>
      /// Delete an elevator.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Mruv.Elevators.DeleteElevatorResponse> DeleteElevatorAsync(global::Mruv.Elevators.DeleteElevatorRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteElevatorAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Delete an elevator.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Mruv.Elevators.DeleteElevatorResponse> DeleteElevatorAsync(global::Mruv.Elevators.DeleteElevatorRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_DeleteElevator, null, options, request);
      }
      /// <summary>
      /// Get available elevator floors.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Mruv.Elevators.GetElevatorFloorsResponse GetElevatorFloors(global::Mruv.Elevators.GetElevatorFloorsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetElevatorFloors(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Get available elevator floors.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Mruv.Elevators.GetElevatorFloorsResponse GetElevatorFloors(global::Mruv.Elevators.GetElevatorFloorsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetElevatorFloors, null, options, request);
      }
      /// <summary>
      /// Get available elevator floors.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Mruv.Elevators.GetElevatorFloorsResponse> GetElevatorFloorsAsync(global::Mruv.Elevators.GetElevatorFloorsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetElevatorFloorsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Get available elevator floors.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Mruv.Elevators.GetElevatorFloorsResponse> GetElevatorFloorsAsync(global::Mruv.Elevators.GetElevatorFloorsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetElevatorFloors, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override MruVElevatorsServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new MruVElevatorsServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(MruVElevatorsServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_CreateElevator, serviceImpl.CreateElevator)
          .AddMethod(__Method_GetElevator, serviceImpl.GetElevator)
          .AddMethod(__Method_UpdateElevator, serviceImpl.UpdateElevator)
          .AddMethod(__Method_DeleteElevator, serviceImpl.DeleteElevator)
          .AddMethod(__Method_GetElevatorFloors, serviceImpl.GetElevatorFloors).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, MruVElevatorsServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_CreateElevator, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Mruv.Elevators.CreateElevatorRequest, global::Mruv.Elevators.CreateElevatorResponse>(serviceImpl.CreateElevator));
      serviceBinder.AddMethod(__Method_GetElevator, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Mruv.Elevators.GetElevatorRequest, global::Mruv.Elevators.GetElevatorResponse>(serviceImpl.GetElevator));
      serviceBinder.AddMethod(__Method_UpdateElevator, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Mruv.Elevators.UpdateElevatorRequest, global::Mruv.Elevators.UpdateElevatorResponse>(serviceImpl.UpdateElevator));
      serviceBinder.AddMethod(__Method_DeleteElevator, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Mruv.Elevators.DeleteElevatorRequest, global::Mruv.Elevators.DeleteElevatorResponse>(serviceImpl.DeleteElevator));
      serviceBinder.AddMethod(__Method_GetElevatorFloors, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Mruv.Elevators.GetElevatorFloorsRequest, global::Mruv.Elevators.GetElevatorFloorsResponse>(serviceImpl.GetElevatorFloors));
    }

  }
}
#endregion
