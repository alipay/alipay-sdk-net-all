using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcRecyclinginvoiceFarmerproductionDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcRecyclinginvoiceFarmerproductionDeleteModel : AopObject
    {
        /// <summary>
        /// 产量记录ID
        /// </summary>
        [XmlElement("farmer_item_id")]
        public string FarmerItemId { get; set; }
    }
}
