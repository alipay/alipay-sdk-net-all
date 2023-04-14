using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecruitContentConfig Data Structure.
    /// </summary>
    [Serializable]
    public class RecruitContentConfig : AopObject
    {
        /// <summary>
        /// 活动报名内容的配置信息CODE。
        /// </summary>
        [XmlElement("config_code")]
        public string ConfigCode { get; set; }

        /// <summary>
        /// 活动报名内容的配置信息CODE对应值。
        /// </summary>
        [XmlElement("config_value")]
        public string ConfigValue { get; set; }
    }
}
