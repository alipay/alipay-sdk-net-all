using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceYuntaskUnitedpidsQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceYuntaskUnitedpidsQueryModel : AopObject
    {
        /// <summary>
        /// 联合商户id
        /// </summary>
        [XmlElement("united_id")]
        public string UnitedId { get; set; }
    }
}
