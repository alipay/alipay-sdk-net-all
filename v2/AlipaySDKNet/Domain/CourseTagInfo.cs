using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CourseTagInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CourseTagInfo : AopObject
    {
        /// <summary>
        /// 标签code (从标签列表接口选取)
        /// </summary>
        [XmlElement("tag_code")]
        public string TagCode { get; set; }
    }
}
