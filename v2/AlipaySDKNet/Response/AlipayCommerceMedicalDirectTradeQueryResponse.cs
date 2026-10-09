using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalDirectTradeQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalDirectTradeQueryResponse : AopResponse
    {
        /// <summary>
        /// 支付宝交易单号
        /// </summary>
        [XmlElement("alipay_trade_no")]
        public string AlipayTradeNo { get; set; }

        /// <summary>
        /// 渠道业务场景
        /// </summary>
        [XmlElement("ch_info")]
        public string ChInfo { get; set; }

        /// <summary>
        /// 创单时传入的创建时间
        /// </summary>
        [XmlElement("gmt_out_create")]
        public string GmtOutCreate { get; set; }

        /// <summary>
        /// 有自费时且自费支付成功时该字段有值
        /// </summary>
        [XmlElement("gmt_own_paid")]
        public string GmtOwnPaid { get; set; }

        /// <summary>
        /// 订单类型
        /// </summary>
        [XmlElement("order_type")]
        public string OrderType { get; set; }

        /// <summary>
        /// 外部交易号
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 支付失败时该字段有值
        /// </summary>
        [XmlElement("own_error_reason")]
        public string OwnErrorReason { get; set; }

        /// <summary>
        /// 自费支付状态（有自费部分时有值）
        /// </summary>
        [XmlElement("own_pay_status")]
        public string OwnPayStatus { get; set; }

        /// <summary>
        /// 自费支付金额，单位是元
        /// </summary>
        [XmlElement("real_amount")]
        public string RealAmount { get; set; }

        /// <summary>
        /// 订单总金额，单位元
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 逸康交易单号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 订单状态
        /// </summary>
        [XmlElement("trade_status")]
        public string TradeStatus { get; set; }
    }
}
