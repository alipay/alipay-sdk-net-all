using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DiagnosisInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class DiagnosisInfoDTO : AopObject
    {
        /// <summary>
        /// 诊断内容
        /// </summary>
        [XmlElement("diacrisis")]
        public string Diacrisis { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
