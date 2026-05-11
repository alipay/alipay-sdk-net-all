using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IncomeOutBusinessItems Data Structure.
    /// </summary>
    [Serializable]
    public class IncomeOutBusinessItems : AopObject
    {
        /// <summary>
        /// 服务项名称
        /// </summary>
        [XmlElement("out_business_name")]
        public string OutBusinessName { get; set; }

        /// <summary>
        /// 服务项id
        /// </summary>
        [XmlElement("out_business_no")]
        public string OutBusinessNo { get; set; }

        /// <summary>
        /// 服务项实收价格，单位：分
        /// </summary>
        [XmlElement("out_business_sale_price")]
        public string OutBusinessSalePrice { get; set; }

        /// <summary>
        /// 外部自定义号：履约单id
        /// </summary>
        [XmlElement("out_custom_no")]
        public string OutCustomNo { get; set; }

        /// <summary>
        /// 结算单据号
        /// </summary>
        [XmlElement("out_settle_no")]
        public string OutSettleNo { get; set; }

        /// <summary>
        /// 结算金额，单位：分
        /// </summary>
        [XmlElement("settle_price")]
        public string SettlePrice { get; set; }

        /// <summary>
        /// 结算时间
        /// </summary>
        [XmlElement("settle_time")]
        public string SettleTime { get; set; }

        /// <summary>
        /// 结算对象id，门店上的服务提供者id，团队id
        /// </summary>
        [XmlElement("to_subject_id")]
        public string ToSubjectId { get; set; }

        /// <summary>
        /// 结算对象类型，门店上的服务提供者类型
        /// </summary>
        [XmlElement("to_subject_type")]
        public string ToSubjectType { get; set; }
    }
}
