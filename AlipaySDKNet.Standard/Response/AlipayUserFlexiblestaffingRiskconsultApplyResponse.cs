using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserFlexiblestaffingRiskconsultApplyResponse.
    /// </summary>
    public class AlipayUserFlexiblestaffingRiskconsultApplyResponse : AopResponse
    {
        /// <summary>
        /// 场景码
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 计费类型，有限枚举： 1.CHARGE（收费）
        /// </summary>
        [XmlElement("charge_type")]
        public string ChargeType { get; set; }

        /// <summary>
        /// 咨询申请的外部单号，幂等参数
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 风险咨询结果集
        /// </summary>
        [XmlElement("risk_results")]
        public RiskApplyConsult RiskResults { get; set; }

        /// <summary>
        /// 建议风险等级
        /// </summary>
        [XmlElement("suggest_risk")]
        public string SuggestRisk { get; set; }
    }
}
