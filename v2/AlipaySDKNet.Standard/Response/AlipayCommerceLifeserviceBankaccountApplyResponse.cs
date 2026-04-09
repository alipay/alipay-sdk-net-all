using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceLifeserviceBankaccountApplyResponse.
    /// </summary>
    public class AlipayCommerceLifeserviceBankaccountApplyResponse : AopResponse
    {
        /// <summary>
        /// 商户展示二维码目标跳转的完整 URL
        /// </summary>
        [XmlElement("apply_url")]
        public string ApplyUrl { get; set; }
    }
}
