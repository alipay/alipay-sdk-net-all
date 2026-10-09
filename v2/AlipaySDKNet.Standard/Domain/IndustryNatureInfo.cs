using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IndustryNatureInfo Data Structure.
    /// </summary>
    [Serializable]
    public class IndustryNatureInfo : AopObject
    {
        /// <summary>
        /// 行业性质有效期结束时间（为空表示永久有效）
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 行业性质
        /// </summary>
        [XmlElement("industry_nature")]
        public string IndustryNature { get; set; }

        /// <summary>
        /// 行业性质有效期开始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }
    }
}
