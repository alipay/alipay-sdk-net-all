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
        /// 保单状态.INEFFECTIVE:未生效、GUARANTEE:保障中、EXPIRED:已失效、SURRENDER:已退保
        /// </summary>
        [XmlElement("policy_status")]
        public string PolicyStatus { get; set; }

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
    }
}
