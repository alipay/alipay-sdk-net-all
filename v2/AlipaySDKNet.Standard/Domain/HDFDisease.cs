using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// HDFDisease Data Structure.
    /// </summary>
    [Serializable]
    public class HDFDisease : AopObject
    {
        /// <summary>
        /// 疾病名称
        /// </summary>
        [XmlElement("disease_name")]
        public string DiseaseName { get; set; }
    }
}
