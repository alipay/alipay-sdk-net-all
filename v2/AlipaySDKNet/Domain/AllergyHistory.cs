using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AllergyHistory Data Structure.
    /// </summary>
    [Serializable]
    public class AllergyHistory : AopObject
    {
        /// <summary>
        /// 名称
        /// </summary>
        [XmlElement("allergen")]
        public string Allergen { get; set; }
    }
}
