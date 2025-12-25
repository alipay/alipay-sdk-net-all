using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceRentOrderPayQueryResponse.
    /// </summary>
    public class AlipayCommerceRentOrderPayQueryResponse : AopResponse
    {
        /// <summary>
        /// 交易附加状态： SELLER_NOT_RECEIVED（买家已付款，卖家未收款）
        /// </summary>
        [XmlElement("additional_status")]
        public string AdditionalStatus { get; set; }

        /// <summary>
        /// 买家实付金额，单位为元，两位小数。该金额代表该笔交易买家实际支付的金额，不包含商户折扣等金额
        /// </summary>
        [XmlElement("buyer_pay_amount")]
        public string BuyerPayAmount { get; set; }

        /// <summary>
        /// 买家在支付宝的用户id
        /// </summary>
        [XmlElement("buyer_user_id")]
        public string BuyerUserId { get; set; }

        /// <summary>
        /// 平台优惠金额
        /// </summary>
        [XmlElement("discount_amount")]
        public string DiscountAmount { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("fund_bill_list")]
        [XmlArrayItem("rent_trade_fund_bill_v_o")]
        public List<RentTradeFundBillVO> FundBillList { get; set; }

        /// <summary>
        /// 商家优惠金额。单位：元。
        /// </summary>
        [XmlElement("mdiscount_amount")]
        public string MdiscountAmount { get; set; }

        /// <summary>
        /// 商家订单号
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 实收金额，单位为元，两位小数。该金额为本笔交易，商户账户能够实际收到的金额
        /// </summary>
        [XmlElement("receipt_amount")]
        public string ReceiptAmount { get; set; }

        /// <summary>
        /// 本次交易打款给卖家的时间
        /// </summary>
        [XmlElement("send_pay_date")]
        public string SendPayDate { get; set; }

        /// <summary>
        /// 交易的订单金额，单位为元，两位小数。该参数的值为支付时传入的total_amount
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 支付宝交易号，在未生成真实交易时，不返回，需要商户多次调用该接口或支付通知，获取最终的交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 交易状态：WAIT_BUYER_PAY（交易创建，等待买家付款）、TRADE_CLOSED（未付款交易超时关闭，或支付完成后全额退款）、TRADE_SUCCESS（交易支付成功）、TRADE_FINISHED（交易结束，不可退款）
        /// </summary>
        [XmlElement("trade_status")]
        public string TradeStatus { get; set; }
    }
}
