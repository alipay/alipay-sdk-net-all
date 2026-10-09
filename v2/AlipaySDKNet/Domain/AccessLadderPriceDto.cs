using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AccessLadderPriceDto Data Structure.
    /// </summary>
    [Serializable]
    public class AccessLadderPriceDto : AopObject
    {
        /// <summary>
        /// minimum_purchase_quantity，用于商品同步，由调用方传入
        /// </summary>
        [XmlElement("minimum_purchase_quantity")]
        public string MinimumPurchaseQuantity { get; set; }

        /// <summary>
        /// origin_unit_price，用于商品同步，由调用方传入
        /// </summary>
        [XmlElement("origin_unit_price")]
        public string OriginUnitPrice { get; set; }

        /// <summary>
        /// unit_price，用于商品同步，由调用方传入
        /// </summary>
        [XmlElement("unit_price")]
        public string UnitPrice { get; set; }
    }
}
