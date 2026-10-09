using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceWithholdrepayorderTradeRefundResponse.
    /// </summary>
    public class AlipayCommerceWithholdrepayorderTradeRefundResponse : AopResponse
    {
        /// <summary>
        /// 用户的登录id
        /// </summary>
        [XmlElement("buyer_logon_id")]
        public string BuyerLogonId { get; set; }

        /// <summary>
        /// 买家支付宝用户唯一标识
        /// </summary>
        [XmlElement("buyer_open_id")]
        public string BuyerOpenId { get; set; }

        /// <summary>
        /// 买家在支付宝的用户id
        /// </summary>
        [XmlElement("buyer_user_id")]
        public string BuyerUserId { get; set; }

        /// <summary>
        /// 本次退款是否发生了资金变化，Y为是，N为否
        /// </summary>
        [XmlElement("fund_change")]
        public string FundChange { get; set; }

        /// <summary>
        /// 退款支付时间
        /// </summary>
        [XmlElement("gmt_refund_pay")]
        public string GmtRefundPay { get; set; }

        /// <summary>
        /// 是否有银行卡冲退，仅当query_options中传入deposit_back_info时返回，返回值为true或false
        /// </summary>
        [XmlElement("has_deposit_back")]
        public string HasDepositBack { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 本次退款金额中买家退款金额;单位：元。 该字段默认不返回；
        /// </summary>
        [XmlElement("present_refund_buyer_amount")]
        public string PresentRefundBuyerAmount { get; set; }

        /// <summary>
        /// 本次退款金额中平台优惠退款金额；单位：元。 该字段默认不返回；
        /// </summary>
        [XmlElement("present_refund_discount_amount")]
        public string PresentRefundDiscountAmount { get; set; }

        /// <summary>
        /// 本次退款金额中商家优惠退款金额；单位：元。 该字段默认不返回；
        /// </summary>
        [XmlElement("present_refund_mdiscount_amount")]
        public string PresentRefundMdiscountAmount { get; set; }

        /// <summary>
        /// 本次退款针对收款方的退收费金额；单位：元。 只在机构间联模式下返回，其它场景下不返回该字段；
        /// </summary>
        [XmlElement("refund_charge_amount")]
        public string RefundChargeAmount { get; set; }

        /// <summary>
        /// 退费信息
        /// </summary>
        [XmlArray("refund_charge_info_list")]
        [XmlArrayItem("industry_refund_charge_info")]
        public List<IndustryRefundChargeInfo> RefundChargeInfoList { get; set; }

        /// <summary>
        /// 退款币种信息
        /// </summary>
        [XmlElement("refund_currency")]
        public string RefundCurrency { get; set; }

        /// <summary>
        /// 退款使用的资金渠道。 只有在签约中指定需要返回资金明细，或者入参的query_options中指定时才返回该字段信息。
        /// </summary>
        [XmlArray("refund_detail_item_list")]
        [XmlArrayItem("industry_trade_fund_bill")]
        public List<IndustryTradeFundBill> RefundDetailItemList { get; set; }

        /// <summary>
        /// 退款总金额。单位：元。 指该笔交易累计已经退款成功的金额。
        /// </summary>
        [XmlElement("refund_fee")]
        public string RefundFee { get; set; }

        /// <summary>
        /// 本次请求退惠营宝金额。单位：元。
        /// </summary>
        [XmlElement("refund_hyb_amount")]
        public string RefundHybAmount { get; set; }

        /// <summary>
        /// 退回的前置资产列表
        /// </summary>
        [XmlElement("refund_preset_paytool_list")]
        public PresetPayToolInfo RefundPresetPaytoolList { get; set; }

        /// <summary>
        /// 退款清算编号，用于清算对账使用； 只在机构间联模式下返回，其它场景下不返回该字段；
        /// </summary>
        [XmlElement("refund_settlement_id")]
        public string RefundSettlementId { get; set; }

        /// <summary>
        /// 本交易支付时使用的所有优惠券信息。 只有在query_options中指定了refund_voucher_detail_list时才返回该字段信息。
        /// </summary>
        [XmlArray("refund_voucher_detail_list")]
        [XmlArrayItem("industry_voucher_detail")]
        public List<IndustryVoucherDetail> RefundVoucherDetailList { get; set; }

        /// <summary>
        /// 本次商户实际退回金额。单位：元。 说明：如需获取该值，需在入参query_options中传入 refund_detail_item_list。
        /// </summary>
        [XmlElement("send_back_fee")]
        public string SendBackFee { get; set; }

        /// <summary>
        /// 交易在支付时候的门店名称，只有在签约中指定需要返回资金明细，或者入参的query_options中指定时才返回该字段信息。
        /// </summary>
        [XmlElement("store_name")]
        public string StoreName { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
