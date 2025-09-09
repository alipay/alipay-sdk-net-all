using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayTradeFinanceCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeFinanceCreateModel : AopObject
    {
        /// <summary>
        /// 下单金额，单位（元，2位小数点），需要和预下单金额一致
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 业务时间。例如，由接入方传入的交易结算时间or卖家提现时间。
        /// </summary>
        [XmlElement("biz_date")]
        public string BizDate { get; set; }

        /// <summary>
        /// 外部订单号, 外部的业务单据号，例如xx平台交易订单id
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 外部请求号，幂等字段，两次请求的外部请求号若一致，则系统认为是一笔请求
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 支付宝结算单号，预下单时生成
        /// </summary>
        [XmlElement("settlement_no")]
        public string SettlementNo { get; set; }
    }
}
