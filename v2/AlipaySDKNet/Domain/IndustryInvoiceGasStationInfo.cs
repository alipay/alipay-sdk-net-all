using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IndustryInvoiceGasStationInfo Data Structure.
    /// </summary>
    [Serializable]
    public class IndustryInvoiceGasStationInfo : AopObject
    {
        /// <summary>
        /// 支付渠道，2026年10月20号后必传
        /// </summary>
        [XmlElement("channel_type")]
        public string ChannelType { get; set; }

        /// <summary>
        /// 加油枪号
        /// </summary>
        [XmlElement("gas_gun_no")]
        public string GasGunNo { get; set; }

        /// <summary>
        /// 加油站站点名称
        /// </summary>
        [XmlElement("gas_station_name")]
        public string GasStationName { get; set; }

        /// <summary>
        /// 加油站纳税人识别号
        /// </summary>
        [XmlElement("gas_station_tax_no")]
        public string GasStationTaxNo { get; set; }

        /// <summary>
        /// 开票触发方式
        /// </summary>
        [XmlElement("invoice_trigger_type")]
        public string InvoiceTriggerType { get; set; }

        /// <summary>
        /// 金额，最多2位小数，最大18位，单位元
        /// </summary>
        [XmlElement("item_amount")]
        public string ItemAmount { get; set; }

        /// <summary>
        /// 数量，最大长度25位
        /// </summary>
        [XmlElement("item_num")]
        public string ItemNum { get; set; }

        /// <summary>
        /// 订单状态
        /// </summary>
        [XmlElement("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 支付时间，格式必须是"yyyy-MM-dd HH:mm:ss"
        /// </summary>
        [XmlElement("pay_time")]
        public string PayTime { get; set; }

        /// <summary>
        /// 车牌号码
        /// </summary>
        [XmlElement("plate_no")]
        public string PlateNo { get; set; }

        /// <summary>
        /// 对应发票明细序号
        /// </summary>
        [XmlElement("related_item_serial_no")]
        public long RelatedItemSerialNo { get; set; }

        /// <summary>
        /// 序号
        /// </summary>
        [XmlElement("serial_no")]
        public long SerialNo { get; set; }

        /// <summary>
        /// 交易流水号，2026年10月20号后必传
        /// </summary>
        [XmlElement("trade_biz_no")]
        public string TradeBizNo { get; set; }

        /// <summary>
        /// 支付单号，2026年10月20号后必传
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 仅当 channel_type=ALIPAY 且为转账场景时必填； 非转账场景不填
        /// </summary>
        [XmlElement("trade_product")]
        public string TradeProduct { get; set; }

        /// <summary>
        /// 单价，最大长度25位，单位元
        /// </summary>
        [XmlElement("unit_price")]
        public string UnitPrice { get; set; }
    }
}
