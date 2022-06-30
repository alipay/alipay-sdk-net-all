using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityBayuQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityBayuQueryModel : AopObject
    {
        /// <summary>
        /// 详细地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }
    }
}
