using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTradePayResponse.
    /// </summary>
    public class AlipayTradePayResponse : AopResponse
    {
        /// <summary>
        /// 先享后付2.0垫资金额,不返回表示没有走垫资，非空表示垫资支付的金额
        /// </summary>
        [XmlElement("advance_amount")]
        public string AdvanceAmount { get; set; }

        /// <summary>
        /// 异步支付受理状态，仅异步支付模式且query_options指定async_pay_info时返回。S：受理成功，支付宝内部会在一定期限内捞起任务推进支付，直到支付成功或超出可重试期限；其它：受理结果未知，可通过查询接口获取交易状态。
        /// </summary>
        [XmlElement("async_pay_apply_status")]
        public string AsyncPayApplyStatus { get; set; }

        /// <summary>
        /// 异步支付模式，目前有五种值： ASYNC_DELAY_PAY(异步延时付款); ASYNC_REALTIME_PAY(异步准实时付款); SYNC_DIRECT_PAY(同步直接扣款); NORMAL_ASYNC_PAY(纯异步付款); QUOTA_OCCUPYIED_ASYNC_PAY(异步支付并且预占了先享后付额度);
        /// </summary>
        [XmlElement("async_payment_mode")]
        public string AsyncPaymentMode { get; set; }

        /// <summary>
        /// 预授权支付模式，该参数仅在信用预授权支付场景下返回。信用预授权支付：CREDIT_PREAUTH_PAY
        /// </summary>
        [XmlElement("auth_trade_pay_mode")]
        public string AuthTradePayMode { get; set; }

        /// <summary>
        /// 间联交易下，返回给机构的信息
        /// </summary>
        [XmlElement("bkagent_resp_info")]
        public BkAgentRespInfo BkagentRespInfo { get; set; }

        /// <summary>
        /// 商户传入业务信息，具体值要和支付宝约定  将商户传入信息分发给相应系统，应用于安全，营销等参数直传场景  格式为json格式
        /// </summary>
        [XmlElement("business_params")]
        public string BusinessParams { get; set; }

        /// <summary>
        /// 买家支付宝账号
        /// </summary>
        [XmlElement("buyer_logon_id")]
        public string BuyerLogonId { get; set; }

        /// <summary>
        /// 买家支付宝用户唯一标识
        /// </summary>
        [XmlElement("buyer_open_id")]
        public string BuyerOpenId { get; set; }

        /// <summary>
        /// 买家付款的金额
        /// </summary>
        [XmlElement("buyer_pay_amount")]
        public string BuyerPayAmount { get; set; }

        /// <summary>
        /// 买家在支付宝的用户id
        /// </summary>
        [XmlElement("buyer_user_id")]
        public string BuyerUserId { get; set; }

        /// <summary>
        /// 买家名称；  买家为个人用户时为买家姓名，买家为企业用户时为企业名称；  默认不返回该信息，需与支付宝约定后配置返回；
        /// </summary>
        [XmlElement("buyer_user_name")]
        public string BuyerUserName { get; set; }

        /// <summary>
        /// 买家用户类型。
        /// </summary>
        [XmlElement("buyer_user_type")]
        public string BuyerUserType { get; set; }

        /// <summary>
        /// 是否可以转为app支付，仅当商户代扣失败场景才会返回该字段信息
        /// </summary>
        [XmlElement("can_turn_to_app_pay")]
        public string CanTurnToAppPay { get; set; }

        /// <summary>
        /// 支付宝卡余额
        /// </summary>
        [XmlElement("card_balance")]
        public string CardBalance { get; set; }

        /// <summary>
        /// 该笔交易针对收款方的收费金额； 只在机构间联模式下返回，其它场景下不返回该字段；
        /// </summary>
        [XmlElement("charge_amount")]
        public string ChargeAmount { get; set; }

        /// <summary>
        /// 费率活动标识。 当交易享受特殊行业或活动费率时，返回该场景的标识。具体场景如下： trade_special_00：订单优惠费率； industry_special_on_00：线上行业特殊费率0； industry_special_on_01：线上行业特殊费率1； industry_special_00：线下行业特殊费率0； industry_special_01：线下行业特殊费率1； bluesea_1：蓝海活动优惠费率标签； 注：只在机构间联模式下返回，其它场景下不返回该字段；
        /// </summary>
        [XmlElement("charge_flags")]
        public string ChargeFlags { get; set; }

        /// <summary>
        /// 计费信息列表
        /// </summary>
        [XmlElement("charge_info_list")]
        public ChargeInfo ChargeInfoList { get; set; }

        /// <summary>
        /// 信用业务单号。信用支付场景才有值。先用后付产品里是芝麻订单号。
        /// </summary>
        [XmlElement("credit_biz_order_id")]
        public string CreditBizOrderId { get; set; }

        /// <summary>
        /// 信用支付模式。表示订单是采用信用支付方式（支付时买家没有出资，需要后续履约）。"creditAdvanceV2"表示芝麻先用后付模式，用户后续需要履约扣款。 此字段只有信用支付场景才有值，商户需要根据字段值单独处理。此字段以后可能扩展其他值，建议商户使用白名单方式识别，对于未识别的值做失败处理，并联系支付宝技术支持人员。
        /// </summary>
        [XmlElement("credit_pay_mode")]
        public string CreditPayMode { get; set; }

        /// <summary>
        /// 平台优惠金额
        /// </summary>
        [XmlElement("discount_amount")]
        public string DiscountAmount { get; set; }

        /// <summary>
        /// 本次交易支付所使用的单品券优惠的商品优惠信息。 只有在query_options中指定时才返回该字段信息。
        /// </summary>
        [XmlElement("discount_goods_detail")]
        public string DiscountGoodsDetail { get; set; }

        /// <summary>
        /// 因公付支付信息，只有入参的query_options中指定时才返回该字段信息
        /// </summary>
        [XmlElement("enterprise_pay_info")]
        public EnterprisePayInfo EnterprisePayInfo { get; set; }

        /// <summary>
        /// 交易支付使用的资金渠道。 只有在签约中指定需要返回资金明细，或者入参的query_options中指定时才返回该字段信息。
        /// </summary>
        [XmlArray("fund_bill_list")]
        [XmlArrayItem("trade_fund_bill")]
        public List<TradeFundBill> FundBillList { get; set; }

        /// <summary>
        /// 交易支付时间
        /// </summary>
        [XmlElement("gmt_payment")]
        public string GmtPayment { get; set; }

        /// <summary>
        /// 惠营宝回票金额
        /// </summary>
        [XmlElement("hyb_amount")]
        public string HybAmount { get; set; }

        /// <summary>
        /// 交易中可给用户开具发票的金额
        /// </summary>
        [XmlElement("invoice_amount")]
        public string InvoiceAmount { get; set; }

        /// <summary>
        /// 商家优惠金额
        /// </summary>
        [XmlElement("mdiscount_amount")]
        public string MdiscountAmount { get; set; }

        /// <summary>
        /// 买家支付宝用户号,该参数已废弃，请不要使用
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 支付币种订单金额
        /// </summary>
        [XmlElement("pay_amount")]
        public string PayAmount { get; set; }

        /// <summary>
        /// 支付币种
        /// </summary>
        [XmlElement("pay_currency")]
        public string PayCurrency { get; set; }

        /// <summary>
        /// 使用集分宝付款的金额
        /// </summary>
        [XmlElement("point_amount")]
        public string PointAmount { get; set; }

        /// <summary>
        /// 当用户使用芝麻信用先享后付时，会返回该字段，代表整笔交易的原始待履约金额，单位元。
        /// </summary>
        [XmlElement("pre_auth_pay_amount")]
        public string PreAuthPayAmount { get; set; }

        /// <summary>
        /// 实收金额
        /// </summary>
        [XmlElement("receipt_amount")]
        public string ReceiptAmount { get; set; }

        /// <summary>
        /// 收款资金类型，当交易收款资金为数字人民币时返回值为“DC”，否则不返回该字段。
        /// </summary>
        [XmlElement("receipt_currency_type")]
        public string ReceiptCurrencyType { get; set; }

        /// <summary>
        /// 结算币种订单金额
        /// </summary>
        [XmlElement("settle_amount")]
        public string SettleAmount { get; set; }

        /// <summary>
        /// 商户指定的结算币种，目前支持英镑：GBP、港币：HKD、美元：USD、新加坡元：SGD、日元：JPY、加拿大元：CAD、澳元：AUD、欧元：EUR、新西兰元：NZD、韩元：KRW、泰铢：THB、瑞士法郎：CHF、瑞典克朗：SEK、丹麦克朗：DKK、挪威克朗：NOK、马来西亚林吉特：MYR、印尼卢比：IDR、菲律宾比索：PHP、毛里求斯卢比：MUR、以色列新谢克尔：ILS、斯里兰卡卢比：LKR、俄罗斯卢布：RUB、阿联酋迪拉姆：AED、捷克克朗：CZK、南非兰特：ZAR、人民币：CNY
        /// </summary>
        [XmlElement("settle_currency")]
        public string SettleCurrency { get; set; }

        /// <summary>
        /// 结算币种兑换标价币种汇率
        /// </summary>
        [XmlElement("settle_trans_rate")]
        public string SettleTransRate { get; set; }

        /// <summary>
        /// 支付清算编号，用于清算对账使用； 只在机构间联模式下返回，其它场景下不返回该字段；
        /// </summary>
        [XmlElement("settlement_id")]
        public string SettlementId { get; set; }

        /// <summary>
        /// 发生支付交易的商户门店名称
        /// </summary>
        [XmlElement("store_name")]
        public string StoreName { get; set; }

        /// <summary>
        /// 碰一下支付信息
        /// </summary>
        [XmlElement("tap_pay_info")]
        public TapPayInfo TapPayInfo { get; set; }

        /// <summary>
        /// 交易金额
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 标价币种, total_amount对应的币种单位。目前支持英镑：GBP、港币：HKD、美元：USD、新加坡元：SGD、日元：JPY、加拿大元：CAD、澳元：AUD、欧元：EUR、新西兰元：NZD、韩元：KRW、泰铢：THB、瑞士法郎：CHF、瑞典克朗：SEK、丹麦克朗：DKK、挪威克朗：NOK、马来西亚林吉特：MYR、印尼卢比：IDR、菲律宾比索：PHP、毛里求斯卢比：MUR、以色列新谢克尔：ILS、斯里兰卡卢比：LKR、俄罗斯卢布：RUB、阿联酋迪拉姆：AED、捷克克朗：CZK、南非兰特：ZAR、人民币：CNY
        /// </summary>
        [XmlElement("trans_currency")]
        public string TransCurrency { get; set; }

        /// <summary>
        /// 标价币种兑换支付币种汇率
        /// </summary>
        [XmlElement("trans_pay_rate")]
        public string TransPayRate { get; set; }

        /// <summary>
        /// 本交易支付时使用的所有优惠券信息。 只有在query_options中指定时才返回该字段信息。
        /// </summary>
        [XmlArray("voucher_detail_list")]
        [XmlArrayItem("voucher_detail")]
        public List<VoucherDetail> VoucherDetailList { get; set; }
    }
}
