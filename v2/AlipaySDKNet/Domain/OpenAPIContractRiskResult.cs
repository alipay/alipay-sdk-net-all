using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenAPIContractRiskResult Data Structure.
    /// </summary>
    [Serializable]
    public class OpenAPIContractRiskResult : AopObject
    {
        /// <summary>
        /// 公司不存在
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 处置提示
        /// </summary>
        [XmlElement("deal_tip")]
        public string DealTip { get; set; }

        /// <summary>
        /// 是否阻断
        /// </summary>
        [XmlElement("is_block")]
        public string IsBlock { get; set; }

        /// <summary>
        /// 扫描通过:SCANNING_Y 扫描不通过:SCANNING_N
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }

        /// <summary>
        /// 下游风险扫描接口返回码
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 下游风险扫描接口返回描述
        /// </summary>
        [XmlElement("result_msg")]
        public string ResultMsg { get; set; }

        /// <summary>
        /// 高风险
        /// </summary>
        [XmlElement("risk_level")]
        public string RiskLevel { get; set; }

        /// <summary>
        /// 风险类型
        /// </summary>
        [XmlElement("risk_name")]
        public string RiskName { get; set; }

        /// <summary>
        /// "PARTB_HIGH"：相对方高风险
        /// </summary>
        [XmlElement("risk_type")]
        public string RiskType { get; set; }

        /// <summary>
        /// 摘要信息
        /// </summary>
        [XmlElement("summay")]
        public string Summay { get; set; }

        /// <summary>
        /// 风险扫描流水号
        /// </summary>
        [XmlElement("v_id")]
        public string VId { get; set; }
    }
}
