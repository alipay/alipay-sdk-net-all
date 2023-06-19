using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InsPolicyDigest Data Structure.
    /// </summary>
    [Serializable]
    public class InsPolicyDigest : AopObject
    {
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
        /// 外部保单号
        /// </summary>
        [XmlElement("out_policy_no")]
        public string OutPolicyNo { get; set; }

        /// <summary>
        /// 保单凭证号;蚂蚁保险平台生成的保单凭证号,用户可以通过此单号去保险公司查询保单信息.
        /// </summary>
        [XmlElement("policy_no")]
        public string PolicyNo { get; set; }

        /// <summary>
        /// 保单状态，该状态是出单时间和保单起止期的比较值，业务可根据业务时间和保单起止期自行比较
        /// </summary>
        [XmlElement("policy_status")]
        public string PolicyStatus { get; set; }

        /// <summary>
        /// 保单类型
        /// </summary>
        [XmlElement("policy_type")]
        public string PolicyType { get; set; }

        /// <summary>
        /// 保费 ;单位分
        /// </summary>
        [XmlElement("premium")]
        public long Premium { get; set; }

        /// <summary>
        /// 保额 ;单位分
        /// </summary>
        [XmlElement("sum_insured")]
        public long SumInsured { get; set; }

        /// <summary>
        /// 退保金额 ;单位分
        /// </summary>
        [XmlElement("surrender_amount")]
        public long SurrenderAmount { get; set; }

        /// <summary>
        /// 退保时间
        /// </summary>
        [XmlElement("surrender_time")]
        public string SurrenderTime { get; set; }
    }
}
