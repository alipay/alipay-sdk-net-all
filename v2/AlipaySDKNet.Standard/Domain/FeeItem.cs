using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FeeItem Data Structure.
    /// </summary>
    [Serializable]
    public class FeeItem : AopObject
    {
        /// <summary>
        /// 计费项编码
        /// </summary>
        [XmlElement("fee_item_code")]
        public string FeeItemCode { get; set; }

        /// <summary>
        /// 计费项名称
        /// </summary>
        [XmlElement("fee_item_name")]
        public string FeeItemName { get; set; }

        /// <summary>
        /// 资源数量
        /// </summary>
        [XmlElement("quantity")]
        public string Quantity { get; set; }

        /// <summary>
        /// 资源数量单位
        /// </summary>
        [XmlElement("quantity_unit")]
        public string QuantityUnit { get; set; }
    }
}
