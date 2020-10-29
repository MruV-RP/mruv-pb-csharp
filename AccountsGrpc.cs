// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: accounts/accounts.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Mruv.Accounts {
  /// <summary>
  /// The MruV accounts service provides procedures for managing players accounts.
  /// This service is an additional/intermediary service between the ORY Kratos &amp; ORY Hydra service.
  /// </summary>
  public static partial class MruVAccountsService
  {
    static readonly string __ServiceName = "mruv.accounts.MruVAccountsService";

    static readonly grpc::Marshaller<global::Mruv.Accounts.RegisterAccountRequest> __Marshaller_mruv_accounts_RegisterAccountRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Mruv.Accounts.RegisterAccountRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Mruv.Accounts.RegisterAccountResponse> __Marshaller_mruv_accounts_RegisterAccountResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Mruv.Accounts.RegisterAccountResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Mruv.Accounts.LogInRequest> __Marshaller_mruv_accounts_LogInRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Mruv.Accounts.LogInRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Mruv.Accounts.LogInResponse> __Marshaller_mruv_accounts_LogInResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Mruv.Accounts.LogInResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Mruv.Accounts.IsAccountExistRequest> __Marshaller_mruv_accounts_IsAccountExistRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Mruv.Accounts.IsAccountExistRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Mruv.Accounts.IsAccountExistResponse> __Marshaller_mruv_accounts_IsAccountExistResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Mruv.Accounts.IsAccountExistResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Mruv.Accounts.GetAccountRequest> __Marshaller_mruv_accounts_GetAccountRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Mruv.Accounts.GetAccountRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Mruv.Accounts.GetAccountResponse> __Marshaller_mruv_accounts_GetAccountResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Mruv.Accounts.GetAccountResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Mruv.Accounts.GetAccountCharactersRequest> __Marshaller_mruv_accounts_GetAccountCharactersRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Mruv.Accounts.GetAccountCharactersRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Mruv.Accounts.GetAccountCharactersResponse> __Marshaller_mruv_accounts_GetAccountCharactersResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Mruv.Accounts.GetAccountCharactersResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::Mruv.Accounts.RegisterAccountRequest, global::Mruv.Accounts.RegisterAccountResponse> __Method_RegisterAccount = new grpc::Method<global::Mruv.Accounts.RegisterAccountRequest, global::Mruv.Accounts.RegisterAccountResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "RegisterAccount",
        __Marshaller_mruv_accounts_RegisterAccountRequest,
        __Marshaller_mruv_accounts_RegisterAccountResponse);

    static readonly grpc::Method<global::Mruv.Accounts.LogInRequest, global::Mruv.Accounts.LogInResponse> __Method_LogIn = new grpc::Method<global::Mruv.Accounts.LogInRequest, global::Mruv.Accounts.LogInResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "LogIn",
        __Marshaller_mruv_accounts_LogInRequest,
        __Marshaller_mruv_accounts_LogInResponse);

    static readonly grpc::Method<global::Mruv.Accounts.IsAccountExistRequest, global::Mruv.Accounts.IsAccountExistResponse> __Method_IsAccountExist = new grpc::Method<global::Mruv.Accounts.IsAccountExistRequest, global::Mruv.Accounts.IsAccountExistResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "IsAccountExist",
        __Marshaller_mruv_accounts_IsAccountExistRequest,
        __Marshaller_mruv_accounts_IsAccountExistResponse);

    static readonly grpc::Method<global::Mruv.Accounts.GetAccountRequest, global::Mruv.Accounts.GetAccountResponse> __Method_GetAccount = new grpc::Method<global::Mruv.Accounts.GetAccountRequest, global::Mruv.Accounts.GetAccountResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetAccount",
        __Marshaller_mruv_accounts_GetAccountRequest,
        __Marshaller_mruv_accounts_GetAccountResponse);

    static readonly grpc::Method<global::Mruv.Accounts.GetAccountCharactersRequest, global::Mruv.Accounts.GetAccountCharactersResponse> __Method_GetAccountCharacters = new grpc::Method<global::Mruv.Accounts.GetAccountCharactersRequest, global::Mruv.Accounts.GetAccountCharactersResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetAccountCharacters",
        __Marshaller_mruv_accounts_GetAccountCharactersRequest,
        __Marshaller_mruv_accounts_GetAccountCharactersResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Mruv.Accounts.AccountsReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of MruVAccountsService</summary>
    [grpc::BindServiceMethod(typeof(MruVAccountsService), "BindService")]
    public abstract partial class MruVAccountsServiceBase
    {
      /// <summary>
      /// Register a new account.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Mruv.Accounts.RegisterAccountResponse> RegisterAccount(global::Mruv.Accounts.RegisterAccountRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Sign into an existing account.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Mruv.Accounts.LogInResponse> LogIn(global::Mruv.Accounts.LogInRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Check, is account with specified login exist. If yes, it returns account id.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Mruv.Accounts.IsAccountExistResponse> IsAccountExist(global::Mruv.Accounts.IsAccountExistRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Get an account.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Mruv.Accounts.GetAccountResponse> GetAccount(global::Mruv.Accounts.GetAccountRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Get an account characters.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Mruv.Accounts.GetAccountCharactersResponse> GetAccountCharacters(global::Mruv.Accounts.GetAccountCharactersRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for MruVAccountsService</summary>
    public partial class MruVAccountsServiceClient : grpc::ClientBase<MruVAccountsServiceClient>
    {
      /// <summary>Creates a new client for MruVAccountsService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public MruVAccountsServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for MruVAccountsService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public MruVAccountsServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected MruVAccountsServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected MruVAccountsServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Register a new account.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Mruv.Accounts.RegisterAccountResponse RegisterAccount(global::Mruv.Accounts.RegisterAccountRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return RegisterAccount(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Register a new account.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Mruv.Accounts.RegisterAccountResponse RegisterAccount(global::Mruv.Accounts.RegisterAccountRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_RegisterAccount, null, options, request);
      }
      /// <summary>
      /// Register a new account.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Mruv.Accounts.RegisterAccountResponse> RegisterAccountAsync(global::Mruv.Accounts.RegisterAccountRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return RegisterAccountAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Register a new account.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Mruv.Accounts.RegisterAccountResponse> RegisterAccountAsync(global::Mruv.Accounts.RegisterAccountRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_RegisterAccount, null, options, request);
      }
      /// <summary>
      /// Sign into an existing account.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Mruv.Accounts.LogInResponse LogIn(global::Mruv.Accounts.LogInRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return LogIn(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Sign into an existing account.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Mruv.Accounts.LogInResponse LogIn(global::Mruv.Accounts.LogInRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_LogIn, null, options, request);
      }
      /// <summary>
      /// Sign into an existing account.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Mruv.Accounts.LogInResponse> LogInAsync(global::Mruv.Accounts.LogInRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return LogInAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Sign into an existing account.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Mruv.Accounts.LogInResponse> LogInAsync(global::Mruv.Accounts.LogInRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_LogIn, null, options, request);
      }
      /// <summary>
      /// Check, is account with specified login exist. If yes, it returns account id.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Mruv.Accounts.IsAccountExistResponse IsAccountExist(global::Mruv.Accounts.IsAccountExistRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return IsAccountExist(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Check, is account with specified login exist. If yes, it returns account id.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Mruv.Accounts.IsAccountExistResponse IsAccountExist(global::Mruv.Accounts.IsAccountExistRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_IsAccountExist, null, options, request);
      }
      /// <summary>
      /// Check, is account with specified login exist. If yes, it returns account id.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Mruv.Accounts.IsAccountExistResponse> IsAccountExistAsync(global::Mruv.Accounts.IsAccountExistRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return IsAccountExistAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Check, is account with specified login exist. If yes, it returns account id.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Mruv.Accounts.IsAccountExistResponse> IsAccountExistAsync(global::Mruv.Accounts.IsAccountExistRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_IsAccountExist, null, options, request);
      }
      /// <summary>
      /// Get an account.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Mruv.Accounts.GetAccountResponse GetAccount(global::Mruv.Accounts.GetAccountRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetAccount(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Get an account.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Mruv.Accounts.GetAccountResponse GetAccount(global::Mruv.Accounts.GetAccountRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetAccount, null, options, request);
      }
      /// <summary>
      /// Get an account.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Mruv.Accounts.GetAccountResponse> GetAccountAsync(global::Mruv.Accounts.GetAccountRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetAccountAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Get an account.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Mruv.Accounts.GetAccountResponse> GetAccountAsync(global::Mruv.Accounts.GetAccountRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetAccount, null, options, request);
      }
      /// <summary>
      /// Get an account characters.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Mruv.Accounts.GetAccountCharactersResponse GetAccountCharacters(global::Mruv.Accounts.GetAccountCharactersRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetAccountCharacters(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Get an account characters.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Mruv.Accounts.GetAccountCharactersResponse GetAccountCharacters(global::Mruv.Accounts.GetAccountCharactersRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetAccountCharacters, null, options, request);
      }
      /// <summary>
      /// Get an account characters.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Mruv.Accounts.GetAccountCharactersResponse> GetAccountCharactersAsync(global::Mruv.Accounts.GetAccountCharactersRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetAccountCharactersAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Get an account characters.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Mruv.Accounts.GetAccountCharactersResponse> GetAccountCharactersAsync(global::Mruv.Accounts.GetAccountCharactersRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetAccountCharacters, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override MruVAccountsServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new MruVAccountsServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(MruVAccountsServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_RegisterAccount, serviceImpl.RegisterAccount)
          .AddMethod(__Method_LogIn, serviceImpl.LogIn)
          .AddMethod(__Method_IsAccountExist, serviceImpl.IsAccountExist)
          .AddMethod(__Method_GetAccount, serviceImpl.GetAccount)
          .AddMethod(__Method_GetAccountCharacters, serviceImpl.GetAccountCharacters).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, MruVAccountsServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_RegisterAccount, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Mruv.Accounts.RegisterAccountRequest, global::Mruv.Accounts.RegisterAccountResponse>(serviceImpl.RegisterAccount));
      serviceBinder.AddMethod(__Method_LogIn, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Mruv.Accounts.LogInRequest, global::Mruv.Accounts.LogInResponse>(serviceImpl.LogIn));
      serviceBinder.AddMethod(__Method_IsAccountExist, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Mruv.Accounts.IsAccountExistRequest, global::Mruv.Accounts.IsAccountExistResponse>(serviceImpl.IsAccountExist));
      serviceBinder.AddMethod(__Method_GetAccount, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Mruv.Accounts.GetAccountRequest, global::Mruv.Accounts.GetAccountResponse>(serviceImpl.GetAccount));
      serviceBinder.AddMethod(__Method_GetAccountCharacters, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Mruv.Accounts.GetAccountCharactersRequest, global::Mruv.Accounts.GetAccountCharactersResponse>(serviceImpl.GetAccountCharacters));
    }

  }
}
#endregion
