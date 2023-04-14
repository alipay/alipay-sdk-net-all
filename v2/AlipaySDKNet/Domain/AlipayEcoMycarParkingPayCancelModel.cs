using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoMycarParkingPayCancelModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarParkingPayCancelModel : AopObject
    {
        /// <summary>
        /// 进场时间(格式"YYYY-MM-DD HH:mm:ss"，24小时制)
        /// </summary>
        [XmlElement("in_time")]
        public string InTime { get; set; }

        /// <summary>
        /// 外部订单号
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 外部进场流水号，与serial_no不能同时为空
        /// </summary>
        [XmlElement("out_serial_no")]
        public string OutSerialNo { get; set; }

        /// <summary>
        /// 出场时间(格式"YYYY-MM-DD HH:mm:ss"，24小时制)
        /// </summary>
        [XmlElement("out_time")]
        public string OutTime { get; set; }

        /// <summary>
        /// 支付宝车场ID
        /// </summary>
        [XmlElement("parking_id")]
        public string ParkingId { get; set; }

        /// <summary>
        /// 支付场景（PLATE_PAY：OCR识别车牌代扣。ETC_PAY：ETC识别车牌代扣。
        /// </summary>
        [XmlElement("pay_scene")]
        public string PayScene { get; set; }

        /// <summary>
        /// 车牌颜色
        /// </summary>
        [XmlElement("plate_color")]
        public string PlateColor { get; set; }

        /// <summary>
        /// 车牌号
        /// </summary>
        [XmlElement("plate_no")]
        public string PlateNo { get; set; }

        /// <summary>
        /// 营销对象
        /// </summary>
        [XmlElement("promo")]
        public ParkingOrderPromo Promo { get; set; }

        /// <summary>
        /// 收款人支付宝账号
        /// </summary>
        [XmlElement("seller_id")]
        public string SellerId { get; set; }

        /// <summary>
        /// 进场流水号，与out_serial_no不能同时为空
        /// </summary>
        [XmlElement("serial_no")]
        public string SerialNo { get; set; }

        /// <summary>
        /// 订单标题，描述订单用途
        /// </summary>
        [XmlElement("subject")]
        public string Subject { get; set; }

        /// <summary>
        /// 订单金额(元)，精确到小数点后两位
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }
    }
}
