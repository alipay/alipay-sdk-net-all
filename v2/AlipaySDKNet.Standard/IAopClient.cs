namespace Aop.Api
{
    /// <summary>
    /// AOP客户端。
    /// </summary>
    public interface IAopClient
    {
        /// <summary>
        /// 调用普通OpenAPI
        /// </summary>
        /// <typeparam name="T">请求参数模板类型</typeparam>
        /// <param name="request">请求参数对象</param>
        /// <returns>响应参数对象</returns>
        T Execute<T>(IAopRequest<T> request) where T : AopResponse;

        /// <summary>
        /// 调用授权OpenAPI
        /// </summary>
        /// <typeparam name="T">请求参数模板类型</typeparam>
        /// <param name="request">请求参数对象</param>
        /// <param name="accessToken">用户授权token</param>
        /// <returns>响应参数对象</returns>
        T Execute<T>(IAopRequest<T> request, string accessToken) where T : AopResponse;

        /// <summary>
        /// 调用授权OpenAPI
        /// </summary>
        /// <typeparam name="T">请求参数模板类型</typeparam>
        /// <param name="request">请求参数对象</param>
        /// <param name="accessToken">用户授权token</param>
        /// <param name="appAuthToken">三方应用授权token</param>
        /// <returns>响应参数对象</returns>
        T Execute<T>(IAopRequest<T> request, string accessToken, string appAuthToken) where T : AopResponse;

        /// <summary>
        /// 调用授权OpenAPI
        /// </summary>
        /// <typeparam name="T">请求参数模板类型</typeparam>
        /// <param name="request">请求参数对象</param>
        /// <param name="accessToken">用户授权token</param>
        /// <param name="appAuthToken">三方应用授权token</param>
        /// <param name="targetAppId">目标AppId，调用SPI三方能力API时需要传递此参数</param>
        /// <returns>响应参数对象</returns>
        T Execute<T>(IAopRequest<T> request, string accessToken, string appAuthToken, string targetAppId) where T : AopResponse;

        /// <summary>
        /// 使用指定的证书，调用普通OpenAPI
        /// </summary>
        /// <typeparam name="T">请求参数模板类型</typeparam>
        /// <param name="request">请求参数对象</param>
        /// <returns>响应参数对象</returns>
        T CertificateExecute<T>(IAopRequest<T> request) where T : AopResponse;

        /// <summary>
        /// 使用指定的证书，调用授权OpenAPI
        /// </summary>
        /// <typeparam name="T">请求参数模板类型</typeparam>
        /// <param name="request">请求参数对象</param>
        /// <param name="accessToken">用户授权token</param>
        /// <returns>响应参数对象</returns>
        T CertificateExecute<T>(IAopRequest<T> request, string accessToken) where T : AopResponse;

        /// <summary>
        /// 使用指定的证书，调用授权OpenAPI
        /// </summary>
        /// <typeparam name="T">请求参数模板类型</typeparam>
        /// <param name="request">请求参数对象</param>
        /// <param name="accessToken">用户授权token</param>
        /// <param name="appAuthToken">三方应用授权token</param>
        /// <returns>响应参数对象</returns>
        T CertificateExecute<T>(IAopRequest<T> request, string accessToken, string appAuthToken) where T : AopResponse;

        /// <summary>
        /// 使用指定的证书，调用授权OpenAPI
        /// </summary>
        /// <typeparam name="T">请求参数模板类型</typeparam>
        /// <param name="request">请求参数对象</param>
        /// <param name="accessToken">用户授权token</param>
        /// <param name="appAuthToken">三方应用授权token</param>
        /// <param name="targetAppId">目标AppId，调用SPI三方能力API时需要传递此参数</param>
        /// <returns>响应参数对象</returns>
        T CertificateExecute<T>(IAopRequest<T> request, string accessToken, string appAuthToken, string targetAppId) where T : AopResponse;

        /// <summary>
        /// 执行AOP公开API请求。
        /// </summary>
        /// <typeparam name="T">领域对象</typeparam>
        /// <param name="request">具体的AOP API请求</param>
        /// <returns>领域对象</returns>
        T pageExecute<T>(IAopRequest<T> request) where T : AopResponse;

        /// <summary>
        /// 执行AOP隐私API请求。
        /// </summary>
        /// <typeparam name="T">领域对象</typeparam>
        /// <param name="request">具体的AOP API请求</param>
        /// <param name="accessToken">用户授权码</param>
        /// <param name="reqMethod">请求方式,两个值可选：POST、GET;</param>
        /// <returns>领域对象</returns>
        T pageExecute<T>(IAopRequest<T> request, string accessToken, string reqMethod) where T : AopResponse;

        /// <summary>
        /// 执行AOP API请求, 支持传递用户授权token和三方应用授权token（token如不需要可传递null）
        /// </summary>
        /// <typeparam name="T">领域对象</typeparam>
        /// <param name="request">具体的AOP API请求</param>
        /// <param name="accessToken">用户授权码</param>
        /// <param name="appAuthToken">三方应用授权码</param>
        /// <param name="reqMethod">请求方式,两个值可选：POST、GET;</param>
        /// <returns>领域对象</returns>
        T pageExecute<T>(IAopRequest<T> request, string accessToken, string appAuthToken, string reqMethod) where T : AopResponse;

        /// <summary>
        /// 执行AOP公开API请求。
        /// </summary>
        /// <typeparam name="T">领域对象</typeparam>
        /// <param name="request">具体的AOP API请求</param>
        /// <returns>领域对象</returns>
        T SdkExecute<T>(IAopRequest<T> request) where T : AopResponse;

        /// <summary>
        /// 执行AOP API请求，支持传递三方应用授权token（token如不需要可传递null）
        /// </summary>
        /// <typeparam name="T">领域对象</typeparam>
        /// <param name="request">具体的AOP API请求</param>
        /// <returns>领域对象</returns>
        T SdkExecute<T>(IAopRequest<T> request, string appAuthToken) where T : AopResponse;
    }
}
