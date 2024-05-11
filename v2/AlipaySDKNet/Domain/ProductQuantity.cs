using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ProductQuantity Data Structure.
    /// </summary>
    [Serializable]
    public class ProductQuantity : AopObject
    {
        /// <summary>
        /// 产品数量
        /// </summary>
        [XmlElement("quantity")]
        public string Quantity { get; set; }

        /// <summary>
        /// 产品定量数量 当前字段已废弃(使用RecycleProduct中的unit_type属性)
        /// </summary>
        [XmlElement("unit_type")]
        public string UnitType { get; set; }
    }
}
