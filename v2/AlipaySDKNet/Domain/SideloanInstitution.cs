using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SideloanInstitution Data Structure.
    /// </summary>
    [Serializable]
    public class SideloanInstitution : AopObject
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
