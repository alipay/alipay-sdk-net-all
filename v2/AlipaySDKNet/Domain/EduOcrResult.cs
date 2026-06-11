using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EduOcrResult Data Structure.
    /// </summary>
    [Serializable]
    public class EduOcrResult : AopObject
    {
        /// <summary>
        /// 教育层次
        /// </summary>
        [XmlElement("edu_level")]
        public string EduLevel { get; set; }

        /// <summary>
        /// 毕（结）业状态
        /// </summary>
        [XmlElement("graduate_conclusion")]
        public string GraduateConclusion { get; set; }

        /// <summary>
        /// 专业
        /// </summary>
        [XmlElement("major")]
        public string Major { get; set; }
    }
}
