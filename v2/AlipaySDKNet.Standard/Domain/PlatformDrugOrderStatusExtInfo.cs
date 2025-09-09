using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PlatformDrugOrderStatusExtInfo Data Structure.
    /// </summary>
    [Serializable]
    public class PlatformDrugOrderStatusExtInfo : AopObject
    {
        /// <summary>
        /// 退款时间
        /// </summary>
        [XmlElement("gmt_refund")]
        public string GmtRefund { get; set; }

        /// <summary>
        /// 物流公司
        /// </summary>
        [XmlElement("logistics_company")]
        public string LogisticsCompany { get; set; }

        /// <summary>
        /// 物流单号
        /// </summary>
        [XmlElement("logistics_id")]
        public string LogisticsId { get; set; }

        /// <summary>
        /// 退款金额
        /// </summary>
        [XmlElement("refund_amount")]
        public string RefundAmount { get; set; }

        /// <summary>
        /// 退款原因
        /// </summary>
        [XmlElement("refund_reason")]
        public string RefundReason { get; set; }
    }
}
