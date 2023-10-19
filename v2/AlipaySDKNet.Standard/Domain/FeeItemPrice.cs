using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FeeItemPrice Data Structure.
    /// </summary>
    [Serializable]
    public class FeeItemPrice : AopObject
    {
        /// <summary>
        /// 单价(分)
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 计费产品码
        /// </summary>
        [XmlElement("cloud_product_code")]
        public string CloudProductCode { get; set; }

        /// <summary>
        /// 计费产品码
        /// </summary>
        [XmlElement("cloud_product_name")]
        public string CloudProductName { get; set; }

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
        /// 计费单位编码
        /// </summary>
        [XmlElement("measuring_unit_code")]
        public string MeasuringUnitCode { get; set; }

        /// <summary>
        /// 计费单位名称
        /// </summary>
        [XmlElement("measuring_unit_name")]
        public string MeasuringUnitName { get; set; }
    }
}
