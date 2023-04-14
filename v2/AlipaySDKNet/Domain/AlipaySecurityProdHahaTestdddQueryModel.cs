using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityProdHahaTestdddQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityProdHahaTestdddQueryModel : AopObject
    {
        /// <summary>
        /// 32
        /// </summary>
        [XmlElement("haha")]
        public string Haha { get; set; }
    }
}
