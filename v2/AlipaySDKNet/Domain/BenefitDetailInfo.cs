using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BenefitDetailInfo Data Structure.
    /// </summary>
    [Serializable]
    public class BenefitDetailInfo : AopObject
    {
        /// <summary>
        /// 权益金额信息
        /// </summary>
        [XmlElement("benefit_amount_info")]
        public BenefitAmountInfo BenefitAmountInfo { get; set; }

        /// <summary>
        /// 权益日期信息
        /// </summary>
        [XmlElement("benefit_date_info")]
        public BenefitDateInfo BenefitDateInfo { get; set; }

        /// <summary>
        /// 权益展示信息
        /// </summary>
        [XmlElement("benefit_display_info")]
        public BenefitDisplayInfo BenefitDisplayInfo { get; set; }

        /// <summary>
        /// 权益id
        /// </summary>
        [XmlElement("benefit_id")]
        public string BenefitId { get; set; }

        /// <summary>
        /// 之前权益申领的操作id
        /// </summary>
        [XmlElement("benefit_operation_id")]
        public string BenefitOperationId { get; set; }

        /// <summary>
        /// 操作时间
        /// </summary>
        [XmlElement("benefit_operation_time")]
        public string BenefitOperationTime { get; set; }

        /// <summary>
        /// 权益发放来源
        /// </summary>
        [XmlElement("benefit_source")]
        public BenefitSource BenefitSource { get; set; }

        /// <summary>
        /// 权益状态
        /// </summary>
        [XmlElement("benefit_status")]
        public string BenefitStatus { get; set; }

        /// <summary>
        /// 权益类型
        /// </summary>
        [XmlElement("benefit_type")]
        public string BenefitType { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [XmlElement("customer_id")]
        public string CustomerId { get; set; }
    }
}
