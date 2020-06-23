// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: organizations/organizations.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Mruv.Organizations {
  /// <summary>
  /// The MruV jobs service provides procedures for managing organizations and fractions.
  /// </summary>
  public static partial class MruVOrganizationsService
  {
    static readonly string __ServiceName = "mruv.organizations.MruVOrganizationsService";

    static readonly grpc::Marshaller<global::Mruv.Organizations.CreateOrganizationRequest> __Marshaller_mruv_organizations_CreateOrganizationRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Mruv.Organizations.CreateOrganizationRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Mruv.Organizations.CreateOrganizationResponse> __Marshaller_mruv_organizations_CreateOrganizationResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Mruv.Organizations.CreateOrganizationResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Mruv.Organizations.GetOrganizationRequest> __Marshaller_mruv_organizations_GetOrganizationRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Mruv.Organizations.GetOrganizationRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Mruv.Organizations.GetOrganizationResponse> __Marshaller_mruv_organizations_GetOrganizationResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Mruv.Organizations.GetOrganizationResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Mruv.Organizations.UpdateOrganizationRequest> __Marshaller_mruv_organizations_UpdateOrganizationRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Mruv.Organizations.UpdateOrganizationRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Mruv.Organizations.UpdateOrganizationResponse> __Marshaller_mruv_organizations_UpdateOrganizationResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Mruv.Organizations.UpdateOrganizationResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Mruv.Organizations.DeleteOrganizationRequest> __Marshaller_mruv_organizations_DeleteOrganizationRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Mruv.Organizations.DeleteOrganizationRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Mruv.Organizations.DeleteOrganizationResponse> __Marshaller_mruv_organizations_DeleteOrganizationResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Mruv.Organizations.DeleteOrganizationResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Mruv.Organizations.AssignLeaderRequest> __Marshaller_mruv_organizations_AssignLeaderRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Mruv.Organizations.AssignLeaderRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Mruv.Organizations.AssignLeaderResponse> __Marshaller_mruv_organizations_AssignLeaderResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Mruv.Organizations.AssignLeaderResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Mruv.Organizations.UnassignLeaderRequest> __Marshaller_mruv_organizations_UnassignLeaderRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Mruv.Organizations.UnassignLeaderRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Mruv.Organizations.UnassignLeaderResponse> __Marshaller_mruv_organizations_UnassignLeaderResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Mruv.Organizations.UnassignLeaderResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::Mruv.Organizations.CreateOrganizationRequest, global::Mruv.Organizations.CreateOrganizationResponse> __Method_CreateOrganization = new grpc::Method<global::Mruv.Organizations.CreateOrganizationRequest, global::Mruv.Organizations.CreateOrganizationResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CreateOrganization",
        __Marshaller_mruv_organizations_CreateOrganizationRequest,
        __Marshaller_mruv_organizations_CreateOrganizationResponse);

    static readonly grpc::Method<global::Mruv.Organizations.GetOrganizationRequest, global::Mruv.Organizations.GetOrganizationResponse> __Method_GetOrganization = new grpc::Method<global::Mruv.Organizations.GetOrganizationRequest, global::Mruv.Organizations.GetOrganizationResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetOrganization",
        __Marshaller_mruv_organizations_GetOrganizationRequest,
        __Marshaller_mruv_organizations_GetOrganizationResponse);

    static readonly grpc::Method<global::Mruv.Organizations.UpdateOrganizationRequest, global::Mruv.Organizations.UpdateOrganizationResponse> __Method_UpdateOrganization = new grpc::Method<global::Mruv.Organizations.UpdateOrganizationRequest, global::Mruv.Organizations.UpdateOrganizationResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UpdateOrganization",
        __Marshaller_mruv_organizations_UpdateOrganizationRequest,
        __Marshaller_mruv_organizations_UpdateOrganizationResponse);

    static readonly grpc::Method<global::Mruv.Organizations.DeleteOrganizationRequest, global::Mruv.Organizations.DeleteOrganizationResponse> __Method_DeleteOrganization = new grpc::Method<global::Mruv.Organizations.DeleteOrganizationRequest, global::Mruv.Organizations.DeleteOrganizationResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeleteOrganization",
        __Marshaller_mruv_organizations_DeleteOrganizationRequest,
        __Marshaller_mruv_organizations_DeleteOrganizationResponse);

    static readonly grpc::Method<global::Mruv.Organizations.AssignLeaderRequest, global::Mruv.Organizations.AssignLeaderResponse> __Method_AssignLeader = new grpc::Method<global::Mruv.Organizations.AssignLeaderRequest, global::Mruv.Organizations.AssignLeaderResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "AssignLeader",
        __Marshaller_mruv_organizations_AssignLeaderRequest,
        __Marshaller_mruv_organizations_AssignLeaderResponse);

    static readonly grpc::Method<global::Mruv.Organizations.UnassignLeaderRequest, global::Mruv.Organizations.UnassignLeaderResponse> __Method_UnassignLeader = new grpc::Method<global::Mruv.Organizations.UnassignLeaderRequest, global::Mruv.Organizations.UnassignLeaderResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UnassignLeader",
        __Marshaller_mruv_organizations_UnassignLeaderRequest,
        __Marshaller_mruv_organizations_UnassignLeaderResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Mruv.Organizations.OrganizationsReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of MruVOrganizationsService</summary>
    [grpc::BindServiceMethod(typeof(MruVOrganizationsService), "BindService")]
    public abstract partial class MruVOrganizationsServiceBase
    {
      /// <summary>
      /// Create a organization.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Mruv.Organizations.CreateOrganizationResponse> CreateOrganization(global::Mruv.Organizations.CreateOrganizationRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Get organization.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Mruv.Organizations.GetOrganizationResponse> GetOrganization(global::Mruv.Organizations.GetOrganizationRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Update organization.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Mruv.Organizations.UpdateOrganizationResponse> UpdateOrganization(global::Mruv.Organizations.UpdateOrganizationRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Delete organization.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Mruv.Organizations.DeleteOrganizationResponse> DeleteOrganization(global::Mruv.Organizations.DeleteOrganizationRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Assign an organization leader. Leader is a main administrator of a organization, have all rights to manage organization.
      /// If the organization leader already exists, the leader will be overwritten.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Mruv.Organizations.AssignLeaderResponse> AssignLeader(global::Mruv.Organizations.AssignLeaderRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Mruv.Organizations.UnassignLeaderResponse> UnassignLeader(global::Mruv.Organizations.UnassignLeaderRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for MruVOrganizationsService</summary>
    public partial class MruVOrganizationsServiceClient : grpc::ClientBase<MruVOrganizationsServiceClient>
    {
      /// <summary>Creates a new client for MruVOrganizationsService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public MruVOrganizationsServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for MruVOrganizationsService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public MruVOrganizationsServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected MruVOrganizationsServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected MruVOrganizationsServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Create a organization.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Mruv.Organizations.CreateOrganizationResponse CreateOrganization(global::Mruv.Organizations.CreateOrganizationRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateOrganization(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Create a organization.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Mruv.Organizations.CreateOrganizationResponse CreateOrganization(global::Mruv.Organizations.CreateOrganizationRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_CreateOrganization, null, options, request);
      }
      /// <summary>
      /// Create a organization.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Mruv.Organizations.CreateOrganizationResponse> CreateOrganizationAsync(global::Mruv.Organizations.CreateOrganizationRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateOrganizationAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Create a organization.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Mruv.Organizations.CreateOrganizationResponse> CreateOrganizationAsync(global::Mruv.Organizations.CreateOrganizationRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_CreateOrganization, null, options, request);
      }
      /// <summary>
      /// Get organization.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Mruv.Organizations.GetOrganizationResponse GetOrganization(global::Mruv.Organizations.GetOrganizationRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetOrganization(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Get organization.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Mruv.Organizations.GetOrganizationResponse GetOrganization(global::Mruv.Organizations.GetOrganizationRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetOrganization, null, options, request);
      }
      /// <summary>
      /// Get organization.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Mruv.Organizations.GetOrganizationResponse> GetOrganizationAsync(global::Mruv.Organizations.GetOrganizationRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetOrganizationAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Get organization.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Mruv.Organizations.GetOrganizationResponse> GetOrganizationAsync(global::Mruv.Organizations.GetOrganizationRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetOrganization, null, options, request);
      }
      /// <summary>
      /// Update organization.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Mruv.Organizations.UpdateOrganizationResponse UpdateOrganization(global::Mruv.Organizations.UpdateOrganizationRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdateOrganization(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Update organization.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Mruv.Organizations.UpdateOrganizationResponse UpdateOrganization(global::Mruv.Organizations.UpdateOrganizationRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_UpdateOrganization, null, options, request);
      }
      /// <summary>
      /// Update organization.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Mruv.Organizations.UpdateOrganizationResponse> UpdateOrganizationAsync(global::Mruv.Organizations.UpdateOrganizationRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdateOrganizationAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Update organization.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Mruv.Organizations.UpdateOrganizationResponse> UpdateOrganizationAsync(global::Mruv.Organizations.UpdateOrganizationRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_UpdateOrganization, null, options, request);
      }
      /// <summary>
      /// Delete organization.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Mruv.Organizations.DeleteOrganizationResponse DeleteOrganization(global::Mruv.Organizations.DeleteOrganizationRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteOrganization(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Delete organization.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Mruv.Organizations.DeleteOrganizationResponse DeleteOrganization(global::Mruv.Organizations.DeleteOrganizationRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_DeleteOrganization, null, options, request);
      }
      /// <summary>
      /// Delete organization.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Mruv.Organizations.DeleteOrganizationResponse> DeleteOrganizationAsync(global::Mruv.Organizations.DeleteOrganizationRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteOrganizationAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Delete organization.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Mruv.Organizations.DeleteOrganizationResponse> DeleteOrganizationAsync(global::Mruv.Organizations.DeleteOrganizationRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_DeleteOrganization, null, options, request);
      }
      /// <summary>
      /// Assign an organization leader. Leader is a main administrator of a organization, have all rights to manage organization.
      /// If the organization leader already exists, the leader will be overwritten.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Mruv.Organizations.AssignLeaderResponse AssignLeader(global::Mruv.Organizations.AssignLeaderRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return AssignLeader(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Assign an organization leader. Leader is a main administrator of a organization, have all rights to manage organization.
      /// If the organization leader already exists, the leader will be overwritten.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Mruv.Organizations.AssignLeaderResponse AssignLeader(global::Mruv.Organizations.AssignLeaderRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_AssignLeader, null, options, request);
      }
      /// <summary>
      /// Assign an organization leader. Leader is a main administrator of a organization, have all rights to manage organization.
      /// If the organization leader already exists, the leader will be overwritten.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Mruv.Organizations.AssignLeaderResponse> AssignLeaderAsync(global::Mruv.Organizations.AssignLeaderRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return AssignLeaderAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Assign an organization leader. Leader is a main administrator of a organization, have all rights to manage organization.
      /// If the organization leader already exists, the leader will be overwritten.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Mruv.Organizations.AssignLeaderResponse> AssignLeaderAsync(global::Mruv.Organizations.AssignLeaderRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_AssignLeader, null, options, request);
      }
      /// <summary>
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Mruv.Organizations.UnassignLeaderResponse UnassignLeader(global::Mruv.Organizations.UnassignLeaderRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UnassignLeader(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Mruv.Organizations.UnassignLeaderResponse UnassignLeader(global::Mruv.Organizations.UnassignLeaderRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_UnassignLeader, null, options, request);
      }
      /// <summary>
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Mruv.Organizations.UnassignLeaderResponse> UnassignLeaderAsync(global::Mruv.Organizations.UnassignLeaderRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UnassignLeaderAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Mruv.Organizations.UnassignLeaderResponse> UnassignLeaderAsync(global::Mruv.Organizations.UnassignLeaderRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_UnassignLeader, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override MruVOrganizationsServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new MruVOrganizationsServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(MruVOrganizationsServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_CreateOrganization, serviceImpl.CreateOrganization)
          .AddMethod(__Method_GetOrganization, serviceImpl.GetOrganization)
          .AddMethod(__Method_UpdateOrganization, serviceImpl.UpdateOrganization)
          .AddMethod(__Method_DeleteOrganization, serviceImpl.DeleteOrganization)
          .AddMethod(__Method_AssignLeader, serviceImpl.AssignLeader)
          .AddMethod(__Method_UnassignLeader, serviceImpl.UnassignLeader).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, MruVOrganizationsServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_CreateOrganization, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Mruv.Organizations.CreateOrganizationRequest, global::Mruv.Organizations.CreateOrganizationResponse>(serviceImpl.CreateOrganization));
      serviceBinder.AddMethod(__Method_GetOrganization, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Mruv.Organizations.GetOrganizationRequest, global::Mruv.Organizations.GetOrganizationResponse>(serviceImpl.GetOrganization));
      serviceBinder.AddMethod(__Method_UpdateOrganization, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Mruv.Organizations.UpdateOrganizationRequest, global::Mruv.Organizations.UpdateOrganizationResponse>(serviceImpl.UpdateOrganization));
      serviceBinder.AddMethod(__Method_DeleteOrganization, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Mruv.Organizations.DeleteOrganizationRequest, global::Mruv.Organizations.DeleteOrganizationResponse>(serviceImpl.DeleteOrganization));
      serviceBinder.AddMethod(__Method_AssignLeader, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Mruv.Organizations.AssignLeaderRequest, global::Mruv.Organizations.AssignLeaderResponse>(serviceImpl.AssignLeader));
      serviceBinder.AddMethod(__Method_UnassignLeader, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Mruv.Organizations.UnassignLeaderRequest, global::Mruv.Organizations.UnassignLeaderResponse>(serviceImpl.UnassignLeader));
    }

  }
}
#endregion