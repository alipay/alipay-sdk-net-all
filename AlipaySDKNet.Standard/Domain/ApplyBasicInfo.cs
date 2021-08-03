using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ApplyBasicInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ApplyBasicInfo : AopObject
    {
        /// <summary>
        /// 保额
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 投保人信息
        /// </summary>
        [XmlElement("apply_info")]
        public InsurancePersonInfo ApplyInfo { get; set; }

        /// <summary>
        /// 受益人信息
        /// </summary>
        [XmlElement("beneficiary_info")]
        public InsurancePersonInfo BeneficiaryInfo { get; set; }

        /// <summary>
        /// 保险条款信息
        /// </summary>
        [XmlElement("insurance_clause")]
        public InsuranceClauseInfo InsuranceClause { get; set; }

        /// <summary>
        /// 保险止期
        /// </summary>
        [XmlElement("insure_end_date")]
        public string InsureEndDate { get; set; }

        /// <summary>
        /// 保险起期
        /// </summary>
        [XmlElement("insure_start_date")]
        public string InsureStartDate { get; set; }

        /// <summary>
        /// 被保人信息
        /// </summary>
        [XmlElement("insured_info")]
        public InsurancePersonInfo InsuredInfo { get; set; }

        /// <summary>
        /// 保费
        /// </summary>
        [XmlElement("premium")]
        public string Premium { get; set; }

        /// <summary>
        /// 费率，最多兼容9位小数
        /// </summary>
        [XmlElement("rate")]
        public string Rate { get; set; }

        /// <summary>
        /// 关联业务订单号
        /// </summary>
        [XmlElement("related_order_no")]
        public string RelatedOrderNo { get; set; }
    }
}
