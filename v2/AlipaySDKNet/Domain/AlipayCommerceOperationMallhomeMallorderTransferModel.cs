using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceOperationMallhomeMallorderTransferModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceOperationMallhomeMallorderTransferModel : AopObject
    {
        /// <summary>
        /// 设备id
        /// </summary>
        [XmlElement("device_id")]
        public string DeviceId { get; set; }

        /// <summary>
        /// 设备类型
        /// </summary>
        [XmlElement("device_type")]
        public string DeviceType { get; set; }

        /// <summary>
        /// 数字化门店id
        /// </summary>
        [XmlElement("digital_poi_id")]
        public string DigitalPoiId { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 商家直联收单pid
        /// </summary>
        [XmlElement("merchant_pid")]
        public string MerchantPid { get; set; }

        /// <summary>
        /// 商家间联收单SMID
        /// </summary>
        [XmlElement("merchant_smid")]
        public string MerchantSmid { get; set; }

        /// <summary>
        /// 商户订单编号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 订单金额(单位:分)
        /// </summary>
        [XmlElement("order_price")]
        public long OrderPrice { get; set; }

        /// <summary>
        /// 设备软件版本编号
        /// </summary>
        [XmlElement("software_version_no")]
        public string SoftwareVersionNo { get; set; }

        /// <summary>
        /// 场地地址
        /// </summary>
        [XmlElement("store_address")]
        public string StoreAddress { get; set; }

        /// <summary>
        /// 门店场地id
        /// </summary>
        [XmlElement("store_id")]
        public string StoreId { get; set; }

        /// <summary>
        /// 场地名称
        /// </summary>
        [XmlElement("store_name")]
        public string StoreName { get; set; }

        /// <summary>
        /// 支付宝交易单号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 支付宝交易金额(单位:分)
        /// </summary>
        [XmlElement("trade_price")]
        public long TradePrice { get; set; }

        /// <summary>
        /// 支付宝交易时间
        /// </summary>
        [XmlElement("trade_time")]
        public string TradeTime { get; set; }
    }
}
