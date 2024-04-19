using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FeeItemInfo Data Structure.
    /// </summary>
    [Serializable]
    public class FeeItemInfo : AopObject
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
        /// 已用百分比
        /// </summary>
        [XmlElement("percent")]
        public string Percent { get; set; }

        /// <summary>
        /// 总量
        /// </summary>
        [XmlElement("total_value")]
        public string TotalValue { get; set; }

        /// <summary>
        /// 计费项单位
        /// </summary>
        [XmlElement("unit")]
        public string Unit { get; set; }

        /// <summary>
        /// 已使用用量
        /// </summary>
        [XmlElement("used_value")]
        public string UsedValue { get; set; }
    }
}
