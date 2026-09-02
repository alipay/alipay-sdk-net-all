using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcRecyclinginvoiceBiztransferauthApplyResponse.
    /// </summary>
    public class AlipayCommerceEcRecyclinginvoiceBiztransferauthApplyResponse : AopResponse
    {
        /// <summary>
        /// 授权流水ID,可用于查询企业授权结果
        /// </summary>
        [XmlElement("auth_id")]
        public string AuthId { get; set; }

        /// <summary>
        /// 企业授权状态
        /// </summary>
        [XmlElement("auth_status")]
        public string AuthStatus { get; set; }

        /// <summary>
        /// 授权链接,通过此链接可以跳转发票平台授权
        /// </summary>
        [XmlElement("auth_url")]
        public string AuthUrl { get; set; }
    }
}
