using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RiskDetectionResultOpenApiDTO Data Structure.
    /// </summary>
    [Serializable]
    public class RiskDetectionResultOpenApiDTO : AopObject
    {
        /// <summary>
        /// 同入参的业务单据号
        /// </summary>
        [XmlElement("document_no")]
        public string DocumentNo { get; set; }

        /// <summary>
        /// 业务单据类型
        /// </summary>
        [XmlElement("document_type")]
        public string DocumentType { get; set; }

        /// <summary>
        /// 当返回为true时，即认为结算风险咨询的结果为需要阻断当前业务流程；为false时，无需阻断
        /// </summary>
        [XmlElement("need_break")]
        public bool NeedBreak { get; set; }

        /// <summary>
        /// 风险点级别的风险检测结果列表
        /// </summary>
        [XmlArray("risk_detection_result_on_risk_point_open_api_dtos")]
        [XmlArrayItem("risk_detection_result_on_risk_point_open_api_d_t_o")]
        public List<RiskDetectionResultOnRiskPointOpenApiDTO> RiskDetectionResultOnRiskPointOpenApiDtos { get; set; }

        /// <summary>
        /// 风险等级
        /// </summary>
        [XmlElement("risk_level")]
        public string RiskLevel { get; set; }

        /// <summary>
        /// 二级业务环节
        /// </summary>
        [XmlElement("second_level_business_link")]
        public string SecondLevelBusinessLink { get; set; }
    }
}
