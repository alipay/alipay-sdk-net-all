using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RightInfo Data Structure.
    /// </summary>
    [Serializable]
    public class RightInfo : AopObject
    {
        /// <summary>
        /// 履约类型
        /// </summary>
        [XmlElement("fulfillment_type")]
        public string FulfillmentType { get; set; }

        /// <summary>
        /// 权益剩余次数
        /// </summary>
        [XmlElement("remaining_times")]
        public string RemainingTimes { get; set; }

        /// <summary>
        /// 权益副标题
        /// </summary>
        [XmlElement("right_subtitle")]
        public string RightSubtitle { get; set; }

        /// <summary>
        /// 权益标题
        /// </summary>
        [XmlElement("right_title")]
        public string RightTitle { get; set; }

        /// <summary>
        /// SKU编码
        /// </summary>
        [XmlElement("sku_code")]
        public string SkuCode { get; set; }

        /// <summary>
        /// 权益总数
        /// </summary>
        [XmlElement("total_times")]
        public string TotalTimes { get; set; }
    }
}
