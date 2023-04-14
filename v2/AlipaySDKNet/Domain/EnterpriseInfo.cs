using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EnterpriseInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EnterpriseInfo : AopObject
    {
        /// <summary>
        /// 公司名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
