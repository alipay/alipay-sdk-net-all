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
        /// 合约机和lite接入模式传设备SN号，千里传音模式传设备deviceName
        /// </summary>
        [XmlElement("device_id")]
        public string DeviceId { get; set; }

        /// <summary>
        /// 可选字段，兼容可能的bizTid传入场景，可不填
        /// </summary>
        [XmlElement("device_id_type")]
        public string DeviceIdType { get; set; }

        /// <summary>
        /// 表示调用时机： AFTER_PAY 支付后 BEFORE_PAY 支付前
        /// </summary>
        [XmlElement("occasion")]
        public string Occasion { get; set; }

        /// <summary>
        /// 固定枚举值（千里传音：ALIYUN，合约机：SDK，lite模式：LITE）
        /// </summary>
        [XmlElement("play_mode")]
        public string PlayMode { get; set; }

        /// <summary>
        /// 间连商户在支付宝体系内的唯一id,一般以2088开头
        /// </summary>
        [XmlElement("smid")]
        public string Smid { get; set; }

        /// <summary>
        /// 合约机模式必传设备sourceId号，千里传音模式必传设备的productKey，lite模式必传分配给服务商的设备型号编码
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
