using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceRentRiskConsultResponse.
    /// </summary>
    public class AlipayCommerceRentRiskConsultResponse : AopResponse
    {
        /// <summary>
        /// Tn_Level类型结果，risk_level字段取值范围T1-T10（T1 ~ T4: 低风险；T5 ~ T6: 中风险；T7 ~ T8: 高风险；T9 ~ T10: 极高风险）
        /// </summary>
        [XmlElement("comprehensive_risk_models")]
        public RentRiskProVO ComprehensiveRiskModels { get; set; }

        /// <summary>
        /// Boolean类型结果，true-命中极低风险 false-未命中极低风险
        /// </summary>
        [XmlElement("extremely_low_risk_models")]
        public RentRiskProVO ExtremelyLowRiskModels { get; set; }

        /// <summary>
        /// Boolean类型结果，true-命中高风险 false-未命中高风险
        /// </summary>
        [XmlElement("high_risk_models")]
        public RentRiskProVO HighRiskModels { get; set; }

        /// <summary>
        /// BASIC-智安盾基础版，面向全量租赁商户； PRO-智安盾专业版，面向签约商户；
        /// </summary>
        [XmlElement("product_edition")]
        public string ProductEdition { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("risk_infos")]
        [XmlArrayItem("rent_risk_info_v_o")]
        public List<RentRiskInfoVO> RiskInfos { get; set; }

        /// <summary>
        /// 对赌实验命中的分组
        /// </summary>
        [XmlElement("vam_group")]
        public string VamGroup { get; set; }
    }
}
