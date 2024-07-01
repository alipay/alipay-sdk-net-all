using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecycleFundsInfo Data Structure.
    /// </summary>
    [Serializable]
    public class RecycleFundsInfo : AopObject
    {
        /// <summary>
        /// 支付宝支付资金流水号(代扣交易不填写) 对应转账接口的出参pay_fund_order_id
        /// </summary>
        [XmlElement("fund_serial_no")]
        public string FundSerialNo { get; set; }

        /// <summary>
        /// 转账类型(prepay-预付款转账, balance-尾款转账, withhold-代扣交易)
        /// </summary>
        [XmlElement("funds_type")]
        public string FundsType { get; set; }

        /// <summary>
        /// 支付宝代扣交易金额，单位为元，不支持千位分隔符，精确到小数点后两位
        /// </summary>
        [XmlElement("trade_amount")]
        public string TradeAmount { get; set; }

        /// <summary>
        /// 支付宝交易订单号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 支付宝交易时间，格式为yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("trade_time")]
        public string TradeTime { get; set; }
    }
}
