using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OfflineLaborInsurancePolicy Data Structure.
    /// </summary>
    [Serializable]
    public class OfflineLaborInsurancePolicy : AopObject
    {
        /// <summary>
        /// 投保人地址信息
        /// </summary>
        [XmlElement("addressee")]
        public OfflineLaborPolicyholderAddress Addressee { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("coverages")]
        [XmlArrayItem("offline_labor_policy_coverage")]
        public List<OfflineLaborPolicyCoverage> Coverages { get; set; }

        /// <summary>
        /// 保单失效时间
        /// </summary>
        [XmlElement("effect_end_time")]
        public string EffectEndTime { get; set; }

        /// <summary>
        /// 保单生效时间
        /// </summary>
        [XmlElement("effect_start_time")]
        public string EffectStartTime { get; set; }

        /// <summary>
        /// 商品ID
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 承保机构名称
        /// </summary>
        [XmlElement("merchant_name")]
        public string MerchantName { get; set; }

        /// <summary>
        /// 外部保单号
        /// </summary>
        [XmlElement("out_policy_no")]
        public string OutPolicyNo { get; set; }

        /// <summary>
        /// 缴费结束时间，即整个保单的最后一期缴费时间，之后不再需要缴费（保障可能继续有效）
        /// </summary>
        [XmlElement("pay_end_time")]
        public string PayEndTime { get; set; }

        /// <summary>
        /// 缴费截止时间，即本期保费最晚什么时候要交完，逾期则保单可能失效
        /// </summary>
        [XmlElement("pay_to_time")]
        public string PayToTime { get; set; }

        /// <summary>
        /// 保单号
        /// </summary>
        [XmlElement("policy_no")]
        public string PolicyNo { get; set; }

        /// <summary>
        /// 保单状态，INEFFECTIVE：表示未生效
        /// </summary>
        [XmlElement("policy_status")]
        public string PolicyStatus { get; set; }

        /// <summary>
        /// 保费，单位：分
        /// </summary>
        [XmlElement("premium")]
        public long Premium { get; set; }

        /// <summary>
        /// 产品名称
        /// </summary>
        [XmlElement("prod_name")]
        public string ProdName { get; set; }

        /// <summary>
        /// 服务商编号
        /// </summary>
        [XmlElement("sp_no")]
        public string SpNo { get; set; }

        /// <summary>
        /// 保额，单位：分
        /// </summary>
        [XmlElement("sum_insured")]
        public long SumInsured { get; set; }

        /// <summary>
        /// 退保金额，单位：分
        /// </summary>
        [XmlElement("surrender_fee")]
        public long SurrenderFee { get; set; }

        /// <summary>
        /// 退保时间
        /// </summary>
        [XmlElement("surrender_time")]
        public string SurrenderTime { get; set; }
    }
}
