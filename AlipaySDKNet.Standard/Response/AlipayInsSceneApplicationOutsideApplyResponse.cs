using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsSceneApplicationOutsideApplyResponse.
    /// </summary>
    public class AlipayInsSceneApplicationOutsideApplyResponse : AopResponse
    {
        /// <summary>
        /// 外部业务号(与入参调用外部业务号一致)
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 保单号
        /// </summary>
        [XmlElement("policy_no")]
        public string PolicyNo { get; set; }

        /// <summary>
        /// 保费(分)
        /// </summary>
        [XmlElement("premium")]
        public long Premium { get; set; }

        /// <summary>
        /// 风险等级  1:正常  2:关注  3:高风险  4:极高风险
        /// </summary>
        [XmlElement("risk_level")]
        public string RiskLevel { get; set; }

        /// <summary>
        /// 保额(分)
        /// </summary>
        [XmlElement("sum_insured")]
        public long SumInsured { get; set; }
    }
}
