using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DeviceExtAttribute Data Structure.
    /// </summary>
    [Serializable]
    public class DeviceExtAttribute : AopObject
    {
        /// <summary>
        /// 设备外挂配件的SN号，仅设备有外挂配件时需要传
        /// </summary>
        [XmlElement("accessory_sn")]
        public string AccessorySn { get; set; }

        /// <summary>
        /// 商家编号，由服务商定义，需要保证在服务商下唯一
        /// </summary>
        [XmlElement("external_id")]
        public string ExternalId { get; set; }

        /// <summary>
        /// 外部门店 ID，如果是间连绑定必有
        /// </summary>
        [XmlElement("external_shop_id")]
        public string ExternalShopId { get; set; }

        /// <summary>
        /// 服务商密钥
        /// </summary>
        [XmlElement("isv_access_token")]
        public string IsvAccessToken { get; set; }

        /// <summary>
        /// 小写字母串_服务商PID
        /// </summary>
        [XmlElement("isv_device_version_tag")]
        public string IsvDeviceVersionTag { get; set; }

        /// <summary>
        /// 卖进订单id，先卖进后绑定模式下必传。 当前字段已废弃(调用此接口创建的订单为预订单，因此字段命名不准确，后续请使用 sales_entry_pre_order_id 字段。)
        /// </summary>
        [XmlElement("sales_entry_order_id")]
        public string SalesEntryOrderId { get; set; }

        /// <summary>
        /// 卖进订单id，批签模式下如果在绑定时用户订单核销成功，但是绑定失败，会返回核销生产的卖进订单id，后续再重试绑定时，可以重新在绑定接口传入该字段，这样则不会占用签约额度。
        /// </summary>
        [XmlElement("sales_order_id")]
        public string SalesOrderId { get; set; }

        /// <summary>
        /// 卖进预订单id
        /// </summary>
        [XmlElement("sales_pre_order_id")]
        public string SalesPreOrderId { get; set; }

        /// <summary>
        /// 卖进方案扩展信息
        /// </summary>
        [XmlElement("sales_solution_ext")]
        public SalesSolutionExt SalesSolutionExt { get; set; }

        /// <summary>
        /// 间连绑定时必有，用于设备左上角展示，可以区分设备所在门店
        /// </summary>
        [XmlElement("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// 间连绑定时选填，用于设备左上角展示，可以区分设备所在门店
        /// </summary>
        [XmlElement("shop_nick_name")]
        public string ShopNickName { get; set; }

        /// <summary>
        /// 卖进方案id，作业时有卖进方案的必传
        /// </summary>
        [XmlElement("solution_id")]
        public string SolutionId { get; set; }

        /// <summary>
        /// 进件服务商 PID
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 表示服务商在开放平台注册的 SPI 服务应用的 app_id，用于标识服务商身份
        /// </summary>
        [XmlElement("spi_app_id")]
        public string SpiAppId { get; set; }

        /// <summary>
        /// 服务商内部唯一标识商家、商家门店等字段信息；
        /// </summary>
        [XmlElement("terminal_bind_info")]
        public string TerminalBindInfo { get; set; }
    }
}
