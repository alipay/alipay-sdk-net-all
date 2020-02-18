using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPaiPartnerResultGetResponse.
    /// </summary>
    public class AlipayPaiPartnerResultGetResponse : AopResponse
    {
        /// <summary>
        /// 路由协议内容,根据不同的协议数据不一样
        /// </summary>
        [XmlElement("data")]
        public string Data { get; set; }

        /// <summary>
        /// 为新浪用户申请的 authToken 访问商品码wap页面时需要使用
        /// </summary>
        [XmlElement("oauth_token")]
        public string OauthToken { get; set; }

        /// <summary>
        /// 码协议：MSPAY（快捷支付） WEBVIEW(内置浏览器打开wap) NATIVE(本地打开app) WEB(外置浏览器打开)
        /// </summary>
        [XmlElement("route_method")]
        public string RouteMethod { get; set; }
    }
}
