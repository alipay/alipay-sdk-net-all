using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingThirdpartyOrderRefundResponse.
    /// </summary>
    public class AlipayMarketingThirdpartyOrderRefundResponse : AopResponse
    {
        /// <summary>
        /// 退款处理失败订单数
        /// </summary>
        [XmlElement("failed_count")]
        public long FailedCount { get; set; }

        /// <summary>
        /// 退款订单明细
        /// </summary>
        [XmlElement("refund_result_list")]
        public ThirdPartyRefundResultList RefundResultList { get; set; }

        /// <summary>
        /// 退款处理成功订单数
        /// </summary>
        [XmlElement("success_count")]
        public long SuccessCount { get; set; }

        /// <summary>
        /// 平台订单编号列表
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
