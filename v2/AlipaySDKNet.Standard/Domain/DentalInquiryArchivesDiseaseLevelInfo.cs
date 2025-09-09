using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DentalInquiryArchivesDiseaseLevelInfo Data Structure.
    /// </summary>
    [Serializable]
    public class DentalInquiryArchivesDiseaseLevelInfo : AopObject
    {
        /// <summary>
        /// 描述病症严重程度的数字化表达
        /// </summary>
        [XmlElement("level_code")]
        public string LevelCode { get; set; }

        /// <summary>
        /// 描述病症名称
        /// </summary>
        [XmlElement("level_name")]
        public string LevelName { get; set; }

        /// <summary>
        /// 描述病症严重程度的文字描述
        /// </summary>
        [XmlElement("level_text")]
        public string LevelText { get; set; }
    }
}
