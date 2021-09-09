using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingActivityVoucherPublishResponse.
    /// </summary>
    public class AlipayMarketingActivityVoucherPublishResponse : AopResponse
    {
        /// <summary>
        /// 预充值链接 限制: 1、有效时间3天
        /// </summary>
        [XmlElement("recharge_url")]
        public string RechargeUrl { get; set; }
    }
}
