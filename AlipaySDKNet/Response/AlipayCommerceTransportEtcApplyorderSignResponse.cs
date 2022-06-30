using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportEtcApplyorderSignResponse.
    /// </summary>
    public class AlipayCommerceTransportEtcApplyorderSignResponse : AopResponse
    {
        /// <summary>
        /// 代扣协议签约页面跳转链接
        /// </summary>
        [XmlElement("etc_deduct_sign_page_url")]
        public string EtcDeductSignPageUrl { get; set; }

        /// <summary>
        /// 代扣协议签约凭证
        /// </summary>
        [XmlElement("etc_deduct_sign_token")]
        public string EtcDeductSignToken { get; set; }
    }
}
