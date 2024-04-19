using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingCampaignWarmcardQueryResponse.
    /// </summary>
    public class AlipayMarketingCampaignWarmcardQueryResponse : AopResponse
    {
        /// <summary>
        /// 是否领过暖心卡
        /// </summary>
        [XmlElement("has_receive")]
        public bool HasReceive { get; set; }

        /// <summary>
        /// 暖心卡优惠券对应是否有剩余金额标识
        /// </summary>
        [XmlElement("voucher_type_remain_info")]
        public string VoucherTypeRemainInfo { get; set; }
    }
}
