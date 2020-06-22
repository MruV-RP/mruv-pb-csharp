// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: server/server.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Mruv.Server {
  /// <summary>
  /// The MruV server service provides procedures for managing game platform server actions.
  /// </summary>
  public static partial class MruVServerService
  {
    static readonly string __ServiceName = "mruv.server.MruVServerService";

    static readonly grpc::Marshaller<global::Mruv.Server.ServerInfo> __Marshaller_mruv_server_ServerInfo = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Mruv.Server.ServerInfo.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Mruv.Server.ServerID> __Marshaller_mruv_server_ServerID = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Mruv.Server.ServerID.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Mruv.Server.GetRegisteredServersRequest> __Marshaller_mruv_server_GetRegisteredServersRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Mruv.Server.GetRegisteredServersRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Mruv.Server.GetRegisteredServersResponse> __Marshaller_mruv_server_GetRegisteredServersResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Mruv.Server.GetRegisteredServersResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Mruv.Server.UpdateServerStatusRequest> __Marshaller_mruv_server_UpdateServerStatusRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Mruv.Server.UpdateServerStatusRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Mruv.Server.UpdateServerStatusResponse> __Marshaller_mruv_server_UpdateServerStatusResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Mruv.Server.UpdateServerStatusResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Mruv.Server.ServerEventsStreamRequest> __Marshaller_mruv_server_ServerEventsStreamRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Mruv.Server.ServerEventsStreamRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Mruv.Server.ServerEvent> __Marshaller_mruv_server_ServerEvent = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Mruv.Server.ServerEvent.Parser.ParseFrom);

    static readonly grpc::Method<global::Mruv.Server.ServerInfo, global::Mruv.Server.ServerID> __Method_RegisterServer = new grpc::Method<global::Mruv.Server.ServerInfo, global::Mruv.Server.ServerID>(
        grpc::MethodType.Unary,
        __ServiceName,
        "RegisterServer",
        __Marshaller_mruv_server_ServerInfo,
        __Marshaller_mruv_server_ServerID);

    static readonly grpc::Method<global::Mruv.Server.GetRegisteredServersRequest, global::Mruv.Server.GetRegisteredServersResponse> __Method_GetRegisteredServers = new grpc::Method<global::Mruv.Server.GetRegisteredServersRequest, global::Mruv.Server.GetRegisteredServersResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetRegisteredServers",
        __Marshaller_mruv_server_GetRegisteredServersRequest,
        __Marshaller_mruv_server_GetRegisteredServersResponse);

    static readonly grpc::Method<global::Mruv.Server.ServerID, global::Mruv.Server.ServerInfo> __Method_GetServerInfo = new grpc::Method<global::Mruv.Server.ServerID, global::Mruv.Server.ServerInfo>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetServerInfo",
        __Marshaller_mruv_server_ServerID,
        __Marshaller_mruv_server_ServerInfo);

    static readonly grpc::Method<global::Mruv.Server.UpdateServerStatusRequest, global::Mruv.Server.UpdateServerStatusResponse> __Method_UpdateServerStatus = new grpc::Method<global::Mruv.Server.UpdateServerStatusRequest, global::Mruv.Server.UpdateServerStatusResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UpdateServerStatus",
        __Marshaller_mruv_server_UpdateServerStatusRequest,
        __Marshaller_mruv_server_UpdateServerStatusResponse);

    static readonly grpc::Method<global::Mruv.Server.ServerEventsStreamRequest, global::Mruv.Server.ServerEvent> __Method_ServerEventsStream = new grpc::Method<global::Mruv.Server.ServerEventsStreamRequest, global::Mruv.Server.ServerEvent>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "ServerEventsStream",
        __Marshaller_mruv_server_ServerEventsStreamRequest,
        __Marshaller_mruv_server_ServerEvent);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Mruv.Server.ServerReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of MruVServerService</summary>
    [grpc::BindServiceMethod(typeof(MruVServerService), "BindService")]
    public abstract partial class MruVServerServiceBase
    {
      /// <summary>
      /// Register instance of server for further managing.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Mruv.Server.ServerID> RegisterServer(global::Mruv.Server.ServerInfo request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Get all registered servers.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Mruv.Server.GetRegisteredServersResponse> GetRegisteredServers(global::Mruv.Server.GetRegisteredServersRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Get game server status.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Mruv.Server.ServerInfo> GetServerInfo(global::Mruv.Server.ServerID request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Update game server status.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Mruv.Server.UpdateServerStatusResponse> UpdateServerStatus(global::Mruv.Server.UpdateServerStatusRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Stream of server events. Events are streamed back in real-time for chosen server.
      ///TODO: Change name to: SubscribeServerEvents
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="responseStream">Used for sending responses back to the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>A task indicating completion of the handler.</returns>
      public virtual global::System.Threading.Tasks.Task ServerEventsStream(global::Mruv.Server.ServerEventsStreamRequest request, grpc::IServerStreamWriter<global::Mruv.Server.ServerEvent> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for MruVServerService</summary>
    public partial class MruVServerServiceClient : grpc::ClientBase<MruVServerServiceClient>
    {
      /// <summary>Creates a new client for MruVServerService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public MruVServerServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for MruVServerService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public MruVServerServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected MruVServerServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected MruVServerServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Register instance of server for further managing.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Mruv.Server.ServerID RegisterServer(global::Mruv.Server.ServerInfo request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return RegisterServer(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Register instance of server for further managing.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Mruv.Server.ServerID RegisterServer(global::Mruv.Server.ServerInfo request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_RegisterServer, null, options, request);
      }
      /// <summary>
      /// Register instance of server for further managing.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Mruv.Server.ServerID> RegisterServerAsync(global::Mruv.Server.ServerInfo request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return RegisterServerAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Register instance of server for further managing.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Mruv.Server.ServerID> RegisterServerAsync(global::Mruv.Server.ServerInfo request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_RegisterServer, null, options, request);
      }
      /// <summary>
      /// Get all registered servers.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Mruv.Server.GetRegisteredServersResponse GetRegisteredServers(global::Mruv.Server.GetRegisteredServersRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetRegisteredServers(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Get all registered servers.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Mruv.Server.GetRegisteredServersResponse GetRegisteredServers(global::Mruv.Server.GetRegisteredServersRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetRegisteredServers, null, options, request);
      }
      /// <summary>
      /// Get all registered servers.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Mruv.Server.GetRegisteredServersResponse> GetRegisteredServersAsync(global::Mruv.Server.GetRegisteredServersRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetRegisteredServersAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Get all registered servers.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Mruv.Server.GetRegisteredServersResponse> GetRegisteredServersAsync(global::Mruv.Server.GetRegisteredServersRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetRegisteredServers, null, options, request);
      }
      /// <summary>
      /// Get game server status.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Mruv.Server.ServerInfo GetServerInfo(global::Mruv.Server.ServerID request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetServerInfo(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Get game server status.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Mruv.Server.ServerInfo GetServerInfo(global::Mruv.Server.ServerID request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetServerInfo, null, options, request);
      }
      /// <summary>
      /// Get game server status.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Mruv.Server.ServerInfo> GetServerInfoAsync(global::Mruv.Server.ServerID request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetServerInfoAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Get game server status.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Mruv.Server.ServerInfo> GetServerInfoAsync(global::Mruv.Server.ServerID request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetServerInfo, null, options, request);
      }
      /// <summary>
      /// Update game server status.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Mruv.Server.UpdateServerStatusResponse UpdateServerStatus(global::Mruv.Server.UpdateServerStatusRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdateServerStatus(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Update game server status.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Mruv.Server.UpdateServerStatusResponse UpdateServerStatus(global::Mruv.Server.UpdateServerStatusRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_UpdateServerStatus, null, options, request);
      }
      /// <summary>
      /// Update game server status.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Mruv.Server.UpdateServerStatusResponse> UpdateServerStatusAsync(global::Mruv.Server.UpdateServerStatusRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdateServerStatusAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Update game server status.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Mruv.Server.UpdateServerStatusResponse> UpdateServerStatusAsync(global::Mruv.Server.UpdateServerStatusRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_UpdateServerStatus, null, options, request);
      }
      /// <summary>
      /// Stream of server events. Events are streamed back in real-time for chosen server.
      ///TODO: Change name to: SubscribeServerEvents
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncServerStreamingCall<global::Mruv.Server.ServerEvent> ServerEventsStream(global::Mruv.Server.ServerEventsStreamRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ServerEventsStream(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Stream of server events. Events are streamed back in real-time for chosen server.
      ///TODO: Change name to: SubscribeServerEvents
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncServerStreamingCall<global::Mruv.Server.ServerEvent> ServerEventsStream(global::Mruv.Server.ServerEventsStreamRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncServerStreamingCall(__Method_ServerEventsStream, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override MruVServerServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new MruVServerServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(MruVServerServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_RegisterServer, serviceImpl.RegisterServer)
          .AddMethod(__Method_GetRegisteredServers, serviceImpl.GetRegisteredServers)
          .AddMethod(__Method_GetServerInfo, serviceImpl.GetServerInfo)
          .AddMethod(__Method_UpdateServerStatus, serviceImpl.UpdateServerStatus)
          .AddMethod(__Method_ServerEventsStream, serviceImpl.ServerEventsStream).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, MruVServerServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_RegisterServer, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Mruv.Server.ServerInfo, global::Mruv.Server.ServerID>(serviceImpl.RegisterServer));
      serviceBinder.AddMethod(__Method_GetRegisteredServers, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Mruv.Server.GetRegisteredServersRequest, global::Mruv.Server.GetRegisteredServersResponse>(serviceImpl.GetRegisteredServers));
      serviceBinder.AddMethod(__Method_GetServerInfo, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Mruv.Server.ServerID, global::Mruv.Server.ServerInfo>(serviceImpl.GetServerInfo));
      serviceBinder.AddMethod(__Method_UpdateServerStatus, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Mruv.Server.UpdateServerStatusRequest, global::Mruv.Server.UpdateServerStatusResponse>(serviceImpl.UpdateServerStatus));
      serviceBinder.AddMethod(__Method_ServerEventsStream, serviceImpl == null ? null : new grpc::ServerStreamingServerMethod<global::Mruv.Server.ServerEventsStreamRequest, global::Mruv.Server.ServerEvent>(serviceImpl.ServerEventsStream));
    }

  }
}
#endregion
