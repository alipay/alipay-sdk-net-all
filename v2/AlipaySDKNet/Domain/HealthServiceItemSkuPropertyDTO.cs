using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// HealthServiceItemSkuPropertyDTO Data Structure.
    /// </summary>
    [Serializable]
    public class HealthServiceItemSkuPropertyDTO : AopObject
    {
        /// <summary>
        /// SKU属性Key展示值
        /// </summary>
        [XmlElement("sku_property_key_display")]
        public string SkuPropertyKeyDisplay { get; set; }

        /// <summary>
        /// SKU属性值展示值
        /// </summary>
        [XmlElement("sku_property_value_display")]
        public string SkuPropertyValueDisplay { get; set; }
    }
}
