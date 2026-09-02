using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ShipAssessmentResultVO Data Structure.
    /// </summary>
    [Serializable]
    public class ShipAssessmentResultVO : AopObject
    {
        /// <summary>
        /// 错误原因，当发货评估结果为null时返回
        /// </summary>
        [XmlElement("error_reason")]
        public string ErrorReason { get; set; }

        /// <summary>
        /// 发货建议 true-建议发货，false-不建议发货
        /// </summary>
        [XmlElement("ship_advice")]
        public bool ShipAdvice { get; set; }
    }
}
