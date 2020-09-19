using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOverseasOpenSchoolQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOverseasOpenSchoolQueryModel : AopObject
    {
        /// <summary>
        /// 学校名称
        /// </summary>
        [XmlElement("school_name")]
        public string SchoolName { get; set; }
    }
}
