using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityProdHaHaInitializeModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityProdHaHaInitializeModel : AopObject
    {
        /// <summary>
        /// 区
        /// </summary>
        [XmlElement("area_code")]
        public string AreaCode { get; set; }
    }
}
