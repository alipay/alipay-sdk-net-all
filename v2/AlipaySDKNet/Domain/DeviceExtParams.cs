using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DeviceExtParams Data Structure.
    /// </summary>
    [Serializable]
    public class DeviceExtParams : AopObject
    {
        /// <summary>
        /// 商户编号，由ISV定义，需要保证在ISV下唯一
        /// </summary>
        [XmlElement("external_id")]
        public string ExternalId { get; set; }

        /// <summary>
        /// 外部门店id，可用绑定必传
        /// </summary>
        [XmlElement("external_shop_id")]
        public string ExternalShopId { get; set; }

        /// <summary>
        /// 支付类型 云支付服务商：ALIPAY_CLOUD 生态服务商：SPI
        /// </summary>
        [XmlElement("payment_type")]
        public string PaymentType { get; set; }

        /// <summary>
        /// 可用绑定时必传，用于设备左上角展示，可以区分设备所在门店
        /// </summary>
        [XmlElement("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// 进件服务商pid
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 表示ISV在开放平台注册的SPI服务应用的app_id，用于标识ISV身份
        /// </summary>
        [XmlElement("spi_app_id")]
        public string SpiAppId { get; set; }

        /// <summary>
        /// isv内部唯一标识商户、商户门店等字段信息；可作为ISV自主对接的扩展字段使用
        /// </summary>
        [XmlElement("terminal_bind_info")]
        public string TerminalBindInfo { get; set; }
    }
}
