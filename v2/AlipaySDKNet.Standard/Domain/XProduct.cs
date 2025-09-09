using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// XProduct Data Structure.
    /// </summary>
    [Serializable]
    public class XProduct : AopObject
    {
        /// <summary>
        /// X产品预订规则
        /// </summary>
        [XmlElement("appoint_policy")]
        public string AppointPolicy { get; set; }

        /// <summary>
        /// X产品预订电话
        /// </summary>
        [XmlElement("booking_phone")]
        public string BookingPhone { get; set; }

        /// <summary>
        /// X产品适用人数
        /// </summary>
        [XmlElement("capacity")]
        public string Capacity { get; set; }

        /// <summary>
        /// 产品的具体数量
        /// </summary>
        [XmlElement("quantity")]
        public string Quantity { get; set; }

        /// <summary>
        /// X产品接待时间
        /// </summary>
        [XmlElement("reception_times")]
        public string ReceptionTimes { get; set; }

        /// <summary>
        /// X产品的分类，目前支持 住、食、享三类，传 “住” 活着其他值即可
        /// </summary>
        [XmlElement("type_name")]
        public string TypeName { get; set; }

        /// <summary>
        /// 酒店价格方案中，套餐对应的X产品id，唯一
        /// </summary>
        [XmlElement("x_product_id")]
        public string XProductId { get; set; }

        /// <summary>
        /// X产品名称
        /// </summary>
        [XmlElement("x_product_name")]
        public string XProductName { get; set; }
    }
}
