using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EnterpriseInformation Data Structure.
    /// </summary>
    [Serializable]
    public class EnterpriseInformation : AopObject
    {
        /// <summary>
        /// 企业名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
