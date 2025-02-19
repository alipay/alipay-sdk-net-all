using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalItemDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalItemDeleteModel : AopObject
    {
        /// <summary>
        /// OMS厂商商品编码, 厂商自行维护
        /// </summary>
        [XmlElement("item_code")]
        public string ItemCode { get; set; }

        /// <summary>
        /// OMS厂商门店编码, 厂商自行维护
        /// </summary>
        [XmlElement("store_code")]
        public string StoreCode { get; set; }
    }
}
