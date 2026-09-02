using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcRecyclinginvoiceFarmerDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcRecyclinginvoiceFarmerDeleteModel : AopObject
    {
        /// <summary>
        /// 农户ID
        /// </summary>
        [XmlElement("farmer_id")]
        public string FarmerId { get; set; }
    }
}
