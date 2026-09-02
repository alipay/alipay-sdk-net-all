using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecycleInspectReportAnswerVO Data Structure.
    /// </summary>
    [Serializable]
    public class RecycleInspectReportAnswerVO : AopObject
    {
        /// <summary>
        /// 是否缺陷项
        /// </summary>
        [XmlElement("defect_option")]
        public bool DefectOption { get; set; }

        /// <summary>
        /// 问题选项编码
        /// </summary>
        [XmlElement("option_code")]
        public string OptionCode { get; set; }

        /// <summary>
        /// 问题选项名称
        /// </summary>
        [XmlElement("option_name")]
        public string OptionName { get; set; }
    }
}
