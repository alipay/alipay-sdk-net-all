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
        /// 订单金额，单位：元
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 收单(销售)产品码， 收钱码：TRANSFER_QRCODE_PAY
        /// </summary>
        [XmlElement("biz_product")]
        public string BizProduct { get; set; }

        /// <summary>
        /// 订单来源渠道
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 6位地级市编码，高德标准
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("driver_open_id")]
        public string DriverOpenId { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("driver_user_id")]
        public string DriverUserId { get; set; }

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
