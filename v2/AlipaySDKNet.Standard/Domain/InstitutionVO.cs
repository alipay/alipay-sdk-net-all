using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InstitutionVO Data Structure.
    /// </summary>
    [Serializable]
    public class InstitutionVO : AopObject
    {
        /// <summary>
        /// 机构编码
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 机构中文名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
