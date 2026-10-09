using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenPaysaasTradeeventSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenPaysaasTradeeventSendModel : AopObject
    {
        /// <summary>
        /// 单位为分，最大值为100000000分
        /// </summary>
        [XmlElement("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// 设备的bizTid，通过sn查询获取
        /// </summary>
        [XmlElement("biz_tid")]
        public string BizTid { get; set; }

        /// <summary>
        /// 按照枚举类型，传入交易事件类型
        /// </summary>
        [XmlElement("event_type")]
        public string EventType { get; set; }

        /// <summary>
        /// 直连商户输入商户pid，间连商户输入商户smid
        /// </summary>
        [XmlElement("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 商家的直间连类型，按照商家类型，选择正确的枚举值。
        /// </summary>
        [XmlElement("merchant_type")]
        public string MerchantType { get; set; }

        /// <summary>
        /// 设备sn
        /// </summary>
        [XmlElement("sn")]
        public string Sn { get; set; }

        /// <summary>
        /// 触发提醒的时间戳，可以不填，不填写，默认为接收到请求的时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 供应商ID
        /// </summary>
        [XmlElement("supply_id")]
        public string SupplyId { get; set; }

        /// <summary>
        /// 交易订单id,生产环境必传
        /// </summary>
        [XmlElement("trade_id")]
        public string TradeId { get; set; }

        /// <summary>
        /// ALIPAY_TRADE 支付宝交易 OTHER 其他交易途径
        /// </summary>
        [XmlElement("trade_type")]
        public string TradeType { get; set; }
    }
}
