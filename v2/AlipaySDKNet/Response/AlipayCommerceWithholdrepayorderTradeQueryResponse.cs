using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceWithholdrepayorderTradeQueryResponse.
    /// </summary>
    public class AlipayCommerceWithholdrepayorderTradeQueryResponse : AopResponse
    {
        /// <summary>
        /// 交易附加状态： SELLER_NOT_RECEIVED（买家已付款，卖家未收款）；
        /// </summary>
        [XmlElement("additional_status")]
        public string AdditionalStatus { get; set; }

        /// <summary>
        /// 支付宝店铺编号
        /// </summary>
        [XmlElement("alipay_store_id")]
        public string AlipayStoreId { get; set; }

        /// <summary>
        /// 间连商户在支付宝端的商户编号； 只在银行间联交易场景下返回该信息；
        /// </summary>
        [XmlElement("alipay_sub_merchant_id")]
        public string AlipaySubMerchantId { get; set; }

        /// <summary>
        /// 异步支付受理状态，仅异步支付模式且query_options指定async_pay_info时返回。S：受理成功，支付宝内部会在一定期限内捞起任务推进支付，直到支付成功或超出可重试期限；其它：受理结果未知，可重试查询。
        /// </summary>
        [XmlElement("async_pay_apply_status")]
        public string AsyncPayApplyStatus { get; set; }

        /// <summary>
        /// 预授权支付模式，该参数仅在信用预授权支付场景下返回。信用预授权支付：CREDIT_PREAUTH_PAY
        /// </summary>
        [XmlElement("auth_trade_pay_mode")]
        public string AuthTradePayMode { get; set; }

        /// <summary>
        /// 账期结算标识，指已完成支付的订单会进行账期管控，不会实时结算。该参数目前会在使用小程序交易组件场景下返回
        /// </summary>
        [XmlElement("biz_settle_mode")]
        public string BizSettleMode { get; set; }

        /// <summary>
        /// 该笔交易所关联的还款计划信息
        /// </summary>
        [XmlElement("biz_withhold_plans")]
        public IndustryWithholdPlanDTO BizWithholdPlans { get; set; }

        /// <summary>
        /// 间联交易下，返回给机构的信息
        /// </summary>
        [XmlElement("bkagent_resp_info")]
        public IndustryBkAgentRespInfo BkagentRespInfo { get; set; }

        /// <summary>
        /// 订单描述； 只在银行间联交易场景下返回该信息；
        /// </summary>
        [XmlElement("body")]
        public string Body { get; set; }

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
        /// 买家名称； 买家为个人用户时为买家姓名，买家为企业用户时为企业名称； 默认不返回该信息，需与支付宝约定后配置返回；
        /// </summary>
        [XmlElement("buyer_user_name")]
        public string BuyerUserName { get; set; }

        /// <summary>
        /// 买家用户类型。CORPORATE:企业用户；PRIVATE:个人用户。
        /// </summary>
        [XmlElement("buyer_user_type")]
        public string BuyerUserType { get; set; }

        /// <summary>
        /// 收银台类型。 用户支付的收银台类型，取值如下： APP：支付宝APP收银台支付； WAP：支付H5收银台支付； 注：只有在无线产品支付接口请求中query_options指定cashier_type才返回改字段。
        /// </summary>
        [XmlElement("cashier_type")]
        public string CashierType { get; set; }

        /// <summary>
        /// 该笔交易针对收款方的收费金额；单位：元。 只在银行间联交易场景下返回该信息
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
        [XmlArray("charge_info_list")]
        [XmlArrayItem("industry_charge_info")]
        public List<IndustryChargeInfo> ChargeInfoList { get; set; }

        /// <summary>
        /// 信用业务单号。信用支付场景才有值，先用后付产品里是芝麻订单号。
        /// </summary>
        [XmlElement("credit_biz_order_id")]
        public string CreditBizOrderId { get; set; }

        /// <summary>
        /// 信用支付模式。表示订单是采用信用支付方式（支付时买家没有出资，需要后续履约）。"creditAdvanceV2"表示芝麻先用后付模式，用户后续需要履约扣款。 此字段只有信用支付场景才有值，商户需要根据字段值单独处理。此字段以后可能扩展其他值，建议商户使用白名单方式识别，对于未识别的值做失败处理，并联系支付宝技术支持人员。
        /// </summary>
        [XmlElement("credit_pay_mode")]
        public string CreditPayMode { get; set; }

        /// <summary>
        /// 平台优惠金额。单位：元。
        /// </summary>
        [XmlElement("discount_amount")]
        public string DiscountAmount { get; set; }

        /// <summary>
        /// 本次交易支付所使用的单品券优惠的商品优惠信息。 只有在query_options中指定时才返回该字段信息。
        /// </summary>
        [XmlElement("discount_goods_detail")]
        public string DiscountGoodsDetail { get; set; }

        /// <summary>
        /// 因公付支付信息
        /// </summary>
        [XmlElement("enterprise_pay_info")]
        public EnterprisePayInfo EnterprisePayInfo { get; set; }

        /// <summary>
        /// 交易额外信息，特殊场景下与支付宝约定返回。 json格式。
        /// </summary>
        [XmlElement("ext_infos")]
        public string ExtInfos { get; set; }

        /// <summary>
        /// 履约详情列表。 只有入参的query_options中指定fulfillment_detail_list并且所查询的交易存在履约明细时才返回该字段信息。
        /// </summary>
        [XmlElement("fulfillment_detail_list")]
        public IndustryFulfillmentDetail FulfillmentDetailList { get; set; }

        /// <summary>
        /// 交易支付使用的资金渠道。 只有在签约中指定需要返回资金明细，或者入参的query_options中指定时才返回该字段信息。
        /// </summary>
        [XmlElement("fund_bill_list")]
        public IndustryTradeFundBill FundBillList { get; set; }

        /// <summary>
        /// 若用户使用花呗分期支付，且商家开通返回此通知参数，则会返回花呗分期信息。json格式其它说明详见花呗分期信息说明。 注意：商家需与支付宝约定后才返回本参数。
        /// </summary>
        [XmlElement("hb_fq_pay_info")]
        public IndustryHbFqPayInfo HbFqPayInfo { get; set; }

        /// <summary>
        /// 惠营宝回票金额。单位：元。
        /// </summary>
        [XmlElement("hyb_amount")]
        public string HybAmount { get; set; }

        /// <summary>
        /// 行业特殊信息（例如在医保卡支付业务中，向用户返回医疗信息）。
        /// </summary>
        [XmlElement("industry_sepc_detail")]
        public string IndustrySepcDetail { get; set; }

        /// <summary>
        /// 行业特殊信息-个账相关
        /// </summary>
        [XmlElement("industry_sepc_detail_acc")]
        public string IndustrySepcDetailAcc { get; set; }

        /// <summary>
        /// 行业特殊信息-统筹相关
        /// </summary>
        [XmlElement("industry_sepc_detail_gov")]
        public string IndustrySepcDetailGov { get; set; }

        /// <summary>
        /// 完整的收费信息
        /// </summary>
        [XmlArray("intact_charge_info_list")]
        [XmlArrayItem("industry_intact_charge_info")]
        public List<IndustryIntactChargeInfo> IntactChargeInfoList { get; set; }

        /// <summary>
        /// 交易中用户支付的可开具发票的金额，单位为元，两位小数。该金额代表该笔交易中可以给用户开具发票的金额
        /// </summary>
        [XmlElement("invoice_amount")]
        public string InvoiceAmount { get; set; }

        /// <summary>
        /// 商家优惠金额。单位：元。
        /// </summary>
        [XmlElement("mdiscount_amount")]
        public string MdiscountAmount { get; set; }

        /// <summary>
        /// 医保信息。入参的query_options中指定时才返回该字段信息。medicareCardType：医保卡类型，"1":"亲情支付","0":"本人支付"，为空默认为本人支付；medicareCardHolderHiddenName：医保卡持卡人姓名。
        /// </summary>
        [XmlElement("medical_insurance_info")]
        public string MedicalInsuranceInfo { get; set; }

        /// <summary>
        /// 买家支付宝用户号，该字段将废弃，不要使用
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 商家订单号
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 公用回传参数。 返回支付时传入的passback_params参数信息
        /// </summary>
        [XmlElement("passback_params")]
        public string PassbackParams { get; set; }

        /// <summary>
        /// 支付币种订单金额，单位见pay_currency
        /// </summary>
        [XmlElement("pay_amount")]
        public string PayAmount { get; set; }

        /// <summary>
        /// 订单支付币种
        /// </summary>
        [XmlElement("pay_currency")]
        public string PayCurrency { get; set; }

        /// <summary>
        /// 带支付宝支付id的信息，暂不对外开放
        /// </summary>
        [XmlArray("payment_info_with_id_list")]
        [XmlArrayItem("industry_payment_info_with_id")]
        public List<IndustryPaymentInfoWithId> PaymentInfoWithIdList { get; set; }

        /// <summary>
        /// 该字段用于描述当前账期交易的场景。
        /// </summary>
        [XmlElement("period_scene")]
        public string PeriodScene { get; set; }

        /// <summary>
        /// 积分支付的金额，单位为元，两位小数。该金额代表该笔交易中用户使用积分支付的金额，比如集分宝或者支付宝实时优惠等
        /// </summary>
        [XmlElement("point_amount")]
        public string PointAmount { get; set; }

        /// <summary>
        /// 实收金额，单位为元，两位小数。该金额为本笔交易，商户账户能够实际收到的金额
        /// </summary>
        [XmlElement("receipt_amount")]
        public string ReceiptAmount { get; set; }

        /// <summary>
        /// 收款资金类型，当交易收款资金为数字人民币时返回值为“DC”，否则不返回该字段。
        /// </summary>
        [XmlElement("receipt_currency_type")]
        public string ReceiptCurrencyType { get; set; }

        /// <summary>
        /// 支付请求的商品明细列表
        /// </summary>
        [XmlArray("req_goods_detail")]
        [XmlArrayItem("goods_detail")]
        public List<GoodsDetail> ReqGoodsDetail { get; set; }

        /// <summary>
        /// 本次交易打款给卖家的时间
        /// </summary>
        [XmlElement("send_pay_date")]
        public string SendPayDate { get; set; }

        /// <summary>
        /// 结算币种订单金额，单位见settle_currency
        /// </summary>
        [XmlElement("settle_amount")]
        public string SettleAmount { get; set; }

        /// <summary>
        /// 订单结算币种，对应支付接口传入的settle_currency，支持英镑：GBP、港币：HKD、美元：USD、新加坡元：SGD、日元：JPY、加拿大元：CAD、澳元：AUD、欧元：EUR、新西兰元：NZD、韩元：KRW、泰铢：THB、瑞士法郎：CHF、瑞典克朗：SEK、丹麦克朗：DKK、挪威克朗：NOK、马来西亚林吉特：MYR、印尼卢比：IDR、菲律宾比索：PHP、毛里求斯卢比：MUR、以色列新谢克尔：ILS、斯里兰卡卢比：LKR、俄罗斯卢布：RUB、阿联酋迪拉姆：AED、捷克克朗：CZK、南非兰特：ZAR
        /// </summary>
        [XmlElement("settle_currency")]
        public string SettleCurrency { get; set; }

        /// <summary>
        /// 结算币种兑换标价币种汇率
        /// </summary>
        [XmlElement("settle_trans_rate")]
        public string SettleTransRate { get; set; }

        /// <summary>
        /// 支付清算编号，用于清算对账使用； 只在银行间联交易场景下返回该信息；
        /// </summary>
        [XmlElement("settlement_id")]
        public string SettlementId { get; set; }

        /// <summary>
        /// 商户门店编号
        /// </summary>
        [XmlElement("store_id")]
        public string StoreId { get; set; }

        /// <summary>
        /// 请求交易支付中的商户店铺的名称
        /// </summary>
        [XmlElement("store_name")]
        public string StoreName { get; set; }

        /// <summary>
        /// 订单标题； 只在银行间联交易场景下返回该信息；
        /// </summary>
        [XmlElement("subject")]
        public string Subject { get; set; }

        /// <summary>
        /// 商户机具终端编号
        /// </summary>
        [XmlElement("terminal_id")]
        public string TerminalId { get; set; }

        /// <summary>
        /// 交易的订单金额，单位为元，两位小数。该参数的值为支付时传入的total_amount
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 返回的交易结算信息，包含分账、补差等信息。 只有在query_options中指定时才返回该字段信息。
        /// </summary>
        [XmlElement("trade_settle_info")]
        public IndustryTradeSettleInfo TradeSettleInfo { get; set; }

        /// <summary>
        /// 交易状态：WAIT_BUYER_PAY（交易创建，等待买家付款）、TRADE_CLOSED（未付款交易超时关闭，或支付完成后全额退款）、TRADE_SUCCESS（交易支付成功）、TRADE_FINISHED（交易结束，不可退款）
        /// </summary>
        [XmlElement("trade_status")]
        public string TradeStatus { get; set; }

        /// <summary>
        /// 标价币种，该参数的值为支付时传入的trans_currency，支持英镑：GBP、港币：HKD、美元：USD、新加坡元：SGD、日元：JPY、加拿大元：CAD、澳元：AUD、欧元：EUR、新西兰元：NZD、韩元：KRW、泰铢：THB、瑞士法郎：CHF、瑞典克朗：SEK、丹麦克朗：DKK、挪威克朗：NOK、马来西亚林吉特：MYR、印尼卢比：IDR、菲律宾比索：PHP、毛里求斯卢比：MUR、以色列新谢克尔：ILS、斯里兰卡卢比：LKR、俄罗斯卢布：RUB、阿联酋迪拉姆：AED、捷克克朗：CZK、南非兰特：ZAR、人民币：CNY、新台币：TWD。当trans_currency 和 settle_currency 不一致时，trans_currency支持人民币：CNY、新台币：TWD
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
        [XmlArrayItem("industry_voucher_detail")]
        public List<IndustryVoucherDetail> VoucherDetailList { get; set; }
    }
}
