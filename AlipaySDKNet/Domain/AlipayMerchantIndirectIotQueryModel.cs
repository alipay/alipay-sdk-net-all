using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantIndirectIotQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantIndirectIotQueryModel : AopObject
    {
        /// <summary>
        /// 设备id，根据不同的设备类型device_id_type传不同的值
        /// </summary>
        [XmlElement("device_id")]
        public string DeviceId { get; set; }

        /// <summary>
        /// 设备id类型，SN指设备sn号，BIZ_TID指蚂蚁iot对应的唯一biz_tid，ALIYUN指阿里云对应的唯一的设备id类型，其他类型待补充
        /// </summary>
        [XmlElement("device_id_type")]
        public string DeviceIdType { get; set; }

        /// <summary>
        /// 表示调用时机： AFTER_PAY 支付后 BEFORE_PAY 支付前
        /// </summary>
        [XmlElement("occasion")]
        public string Occasion { get; set; }

        /// <summary>
        /// 最终营销文案的播报方式 SDK：指服务商的设备接入了支付宝SDK，最终由支付宝播报； ALIYUN:指服务商接入了阿里云的播报平台，最终服务商消费返回的字段，通过阿里云平台进行播报
        /// </summary>
        [XmlElement("play_mode")]
        public string PlayMode { get; set; }

        /// <summary>
        /// 间连商户id
        /// </summary>
        [XmlElement("smid")]
        public string Smid { get; set; }

        /// <summary>
        /// 补充定义设备device_id,当device_id_type是SN时，传对应的服务商source_id。 其他场景待补充
        /// </summary>
        [XmlElement("suppler_id")]
        public string SupplerId { get; set; }

        /// <summary>
        /// 交易订单id
        /// </summary>
        [XmlElement("trade_id")]
        public string TradeId { get; set; }

        /// <summary>
        /// 交易类型 可选值: ALIPAY_TRADE 支付宝交易 OTHER 其他交易途径
        /// </summary>
        [XmlElement("trade_type")]
        public string TradeType { get; set; }
    }
}
