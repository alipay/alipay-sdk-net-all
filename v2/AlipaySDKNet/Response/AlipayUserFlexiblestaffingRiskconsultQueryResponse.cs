using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserFlexiblestaffingRiskconsultQueryResponse.
    /// </summary>
    public class AlipayUserFlexiblestaffingRiskconsultQueryResponse : AopResponse
    {
        /// <summary>
        /// 场景码
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 计费类型，有限枚举： 1.CHARGE（收费） 2.NO_CHARGE（不计费）
        /// </summary>
        [XmlElement("charge_type")]
        public string ChargeType { get; set; }

        /// <summary>
        /// 【已废弃】咨询参与方信息，默认不返回
        /// </summary>
        [XmlElement("consult_party")]
        public ConsultParticipant ConsultParty { get; set; }

        /// <summary>
        /// 企业信息
        /// </summary>
        [XmlElement("enterprise_info")]
        public EnterpriseInfo EnterpriseInfo { get; set; }

        /// <summary>
        /// 咨询外部单号，和接口输入的外部单号保持一致
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
        [XmlArray("risk_results")]
        [XmlArrayItem("risk_consult_result")]
        public List<RiskConsultResult> RiskResults { get; set; }

        /// <summary>
        /// 建议风险
        /// </summary>
        [XmlElement("suggest_risk")]
        public string SuggestRisk { get; set; }
    }
}
