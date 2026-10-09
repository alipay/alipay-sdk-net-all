using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ContentRiskResult Data Structure.
    /// </summary>
    [Serializable]
    public class ContentRiskResult : AopObject
    {
        /// <summary>
        /// 风险详细信息
        /// </summary>
        [XmlArray("content_risk_details")]
        [XmlArrayItem("content_risk_detail")]
        public List<ContentRiskDetail> ContentRiskDetails { get; set; }

        /// <summary>
        /// 以文件为主维度的风险信息聚合结果
        /// </summary>
        [XmlArray("contents")]
        [XmlArrayItem("content_risks")]
        public List<ContentRisks> Contents { get; set; }

        /// <summary>
        /// 审核状态：枚举值，唯一 。 ROBOT_PASS：机审通过  ROBOT_REVIEW_REJECT：机审驳回  ROBOT_FAIL：机审失败
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }

        /// <summary>
        /// 审核规则数
        /// </summary>
        [XmlElement("rl_cnt")]
        public string RlCnt { get; set; }
    }
}
