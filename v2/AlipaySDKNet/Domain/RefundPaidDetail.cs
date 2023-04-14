using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RefundPaidDetail Data Structure.
    /// </summary>
    [Serializable]
    public class RefundPaidDetail : AopObject
    {
        /// <summary>
        /// 退已打款计划编号
        /// </summary>
        [XmlElement("plan_id")]
        public string PlanId { get; set; }

        /// <summary>
        /// 退已打款金额，单位元，如果不传，就默认全退
        /// </summary>
        [XmlElement("refund_amount")]
        public string RefundAmount { get; set; }

        /// <summary>
        /// 退分账信息
        /// </summary>
        [XmlArray("refund_royalty_info_list")]
        [XmlArrayItem("tuition_refund_royalty_info")]
        public List<TuitionRefundRoyaltyInfo> RefundRoyaltyInfoList { get; set; }
    }
}
