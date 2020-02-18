using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMobilePublicAuthGettokenResponse.
    /// </summary>
    public class AlipayMobilePublicAuthGettokenResponse : AopResponse
    {
        /// <summary>
        /// 返回码。处理成功：200；处理失败：请参考返回码。
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 支付宝返回的处理结果说明，请参考返回码
        /// </summary>
        [XmlElement("msg")]
        public string Msg { get; set; }

        /// <summary>
        /// 跳转到授权页面需要的Token
        /// </summary>
        [XmlElement("token")]
        public string Token { get; set; }
    }
}
