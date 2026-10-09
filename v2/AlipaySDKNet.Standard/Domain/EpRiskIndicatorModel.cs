using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EpRiskIndicatorModel Data Structure.
    /// </summary>
    [Serializable]
    public class EpRiskIndicatorModel : AopObject
    {
        /// <summary>
        /// 指标码值
        /// </summary>
        [XmlElement("label_code")]
        public string LabelCode { get; set; }

        /// <summary>
        /// 指标名称
        /// </summary>
        [XmlElement("label_name")]
        public string LabelName { get; set; }

        /// <summary>
        /// 指标数值
        /// </summary>
        [XmlElement("label_value")]
        public string LabelValue { get; set; }
    }
}
