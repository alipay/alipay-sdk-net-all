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
        /// 长租/汽车订阅：Tn_Level类型结果，risk_level字段取值范围T1-T10（T1 ~ T4: 低风险；T5 ~ T6: 中风险；T7 ~ T8: 高风险；T9 ~ T10: 极高风险） 短租：Sn_Level类型结果, risk_level字段取值范围S1-S5 （S1-S3：低风险，S4：中风险，S5：高风险）
        /// </summary>
        [XmlElement("comprehensive_risk_models")]
        public RentRiskProVO ComprehensiveRiskModels { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("consult_fail_reason")]
        [XmlArrayItem("consult_fail_reason")]
        public List<ConsultFailReason> ConsultFailReason { get; set; }

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
        /// BASIC-租安盾基础版，面向全量租赁商户； PRO-租安盾专业版，面向签约商户；
        /// </summary>
        [XmlElement("product_edition")]
        public string ProductEdition { get; set; }

        /// <summary>
        /// 风控基础信息
        /// </summary>
        [XmlElement("risk_basic_info")]
        public RiskBasicInfoVO RiskBasicInfo { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("risk_infos")]
        [XmlArrayItem("rent_risk_info_v_o")]
        public List<RentRiskInfoVO> RiskInfos { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("ship_goods_risk_models")]
        [XmlArrayItem("ship_goods_risk_v_o")]
        public List<ShipGoodsRiskVO> ShipGoodsRiskModels { get; set; }

        /// <summary>
        /// 联营商户订单分组
        /// </summary>
        [XmlElement("vam_group")]
        public string VamGroup { get; set; }

        /// <summary>
        /// 【注意事项】此字段返回需要满足以下条件 1.3C租赁场景需签约租安盾产品  2.订单需要完成代扣或免押签约后，才会返回值。  3.租安盾产品订单——免押场景下需要配置租安盾策略且拉起免押受理台的策略是租安盾策略； 4.使用的风控策略类型为芝麻租赁租安盾长租策略: risk_policy_value=zhimazulin_zuandun 5.接口查询参数请求中?consult_risk_types=VERTICAL_RENT_RISK 其他信息可参考租安盾产品接入指南。
        /// </summary>
        [XmlElement("vertical_risk_models")]
        public VerticalRiskVO VerticalRiskModels { get; set; }
    }
}
