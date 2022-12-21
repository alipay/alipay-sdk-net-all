using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingActivityOrdervoucherRefundResponse.
    /// </summary>
    public class AlipayMarketingActivityOrdervoucherRefundResponse : AopResponse
    {
        /// <summary>
        /// 优惠券活动id
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 券核销详情返回结果
        /// </summary>
        [XmlElement("voucher_use_detail_result_info")]
        public VoucherUseDetailResultInfo VoucherUseDetailResultInfo { get; set; }
    }
}
