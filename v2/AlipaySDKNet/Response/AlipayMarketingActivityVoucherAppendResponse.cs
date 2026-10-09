using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingActivityVoucherAppendResponse.
    /// </summary>
    public class AlipayMarketingActivityVoucherAppendResponse : AopResponse
    {
        /// <summary>
        /// 预充值链接  限制 有效时间3天
        /// </summary>
        [XmlElement("recharge_url")]
        public string RechargeUrl { get; set; }
    }
}
