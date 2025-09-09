using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportNpayOrderCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportNpayOrderCreateModel : AopObject
    {
        /// <summary>
        /// 订单金额
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 订单来源渠道
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 外部订单号
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 设备序列号，为一串数字或字母，一般为电子产品的标识码
        /// </summary>
        [XmlElement("sn")]
        public string Sn { get; set; }

        /// <summary>
        /// 行程信息
        /// </summary>
        [XmlElement("trip_info")]
        public string TripInfo { get; set; }
    }
}
