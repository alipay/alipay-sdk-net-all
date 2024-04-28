using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTradeFastpayRefundQueryResponse.
    /// </summary>
    public class AlipayTradeFastpayRefundQueryResponse : AopResponse
    {
        /// <summary>
        /// 银行卡冲退信息； 默认不返回该信息，需要在入参的query_options中指定"deposit_back_info"值时才返回该字段信息。
        /// </summary>
        [XmlElement("deposit_back_info")]
        public DepositBackInfo DepositBackInfo { get; set; }

        /// <summary>
        /// 银行卡冲退信息列表。 默认不返回该信息，需要在入参的query_options中指定"deposit_back_info_list"值时才返回该字段信息。
        /// </summary>
        [XmlArray("deposit_back_info_list")]
        [XmlArrayItem("deposit_back_info")]
        public List<DepositBackInfo> DepositBackInfoList { get; set; }

        /// <summary>
        /// 因公付退款信息，只有入参的query_options中指定enterprise_pay_info时才返回该字段信息
        /// </summary>
        [XmlElement("enterprise_pay_info")]
        public EnterprisePayInfo EnterprisePayInfo { get; set; }

        /// <summary>
        /// 退款失败错误码。只在使用异步退款接口情况下才会返回该字段
        /// </summary>
        [XmlElement("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 退款时间。默认不返回该信息，需要在入参的query_options中指定"gmt_refund_pay"值时才返回该字段信息。
        /// </summary>
        [XmlElement("gmt_refund_pay")]
        public string GmtRefundPay { get; set; }

        /// <summary>
        /// 行业特殊信息（例如在医保卡支付退款中，医保局向商户返回医疗信息）。
        /// </summary>
        [XmlElement("industry_sepc_detail")]
        public string IndustrySepcDetail { get; set; }

        /// <summary>
        /// 本笔退款对应的退款请求号
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 创建交易传入的商户订单号
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 本次退款金额中买家退款金额。单位：元。 该字段默认不返回；
        /// </summary>
        [XmlElement("present_refund_buyer_amount")]
        public string PresentRefundBuyerAmount { get; set; }

        /// <summary>
        /// 本次退款金额中平台优惠退款金额。单位：元。 该字段默认不返回；
        /// </summary>
        [XmlElement("present_refund_discount_amount")]
        public string PresentRefundDiscountAmount { get; set; }

        /// <summary>
        /// 本次退款金额中商家优惠退款金额。单位：元。 该字段默认不返回；
        /// </summary>
        [XmlElement("present_refund_mdiscount_amount")]
        public string PresentRefundMdiscountAmount { get; set; }

        /// <summary>
        /// 本次退款请求，对应的退款金额。单位：元。
        /// </summary>
        [XmlElement("refund_amount")]
        public string RefundAmount { get; set; }

        /// <summary>
        /// 若支付渠道包含医保统筹、个账，则显示退款的渠道信息。如统筹OUTSIDEGOVCARD，个账OUTSIDEACCCARD
        /// </summary>
        [XmlElement("refund_channel_list")]
        public string RefundChannelList { get; set; }

        /// <summary>
        /// 若支付渠道包含医保统筹、个账，全渠道退款成功时返回SUCCESS，全失败时返回FAIL，部分成功时返回PART_SUCCESS
        /// </summary>
        [XmlElement("refund_channel_status")]
        public string RefundChannelStatus { get; set; }

        /// <summary>
        /// 本次退款针对收款方的退收费金额；单位：元。 只在机构间联模式下返回，其它场景下不返回该字段；
        /// </summary>
        [XmlElement("refund_charge_amount")]
        public string RefundChargeAmount { get; set; }

        /// <summary>
        /// 退费信息
        /// </summary>
        [XmlArray("refund_charge_info_list")]
        [XmlArrayItem("refund_charge_info")]
        public List<RefundChargeInfo> RefundChargeInfoList { get; set; }

        /// <summary>
        /// 本次退款使用的资金渠道； 默认不返回该信息，需要在入参的query_options中指定"refund_detail_item_list"值时才返回该字段信息。
        /// </summary>
        [XmlArray("refund_detail_item_list")]
        [XmlArrayItem("trade_fund_bill")]
        public List<TradeFundBill> RefundDetailItemList { get; set; }

        /// <summary>
        /// 本次退款金额中退惠营宝的金额。单位：元。
        /// </summary>
        [XmlElement("refund_hyb_amount")]
        public string RefundHybAmount { get; set; }

        /// <summary>
        /// 发起退款时，传入的退款原因
        /// </summary>
        [XmlElement("refund_reason")]
        public string RefundReason { get; set; }

        /// <summary>
        /// 退分账明细信息，当前仅在直付通产品中返回。
        /// </summary>
        [XmlArray("refund_royaltys")]
        [XmlArrayItem("refund_royalty_result")]
        public List<RefundRoyaltyResult> RefundRoyaltys { get; set; }

        /// <summary>
        /// 退款清算编号，用于清算对账使用； 只在机构间联模式下返回，其它场景下不返回该字段；
        /// </summary>
        [XmlElement("refund_settlement_id")]
        public string RefundSettlementId { get; set; }

        /// <summary>
        /// 退款状态。枚举值： REFUND_SUCCESS 退款处理成功； 未返回该字段表示退款请求未收到或者退款失败； 注：如果退款查询发起时间早于退款时间，或者间隔退款发起时间太短，可能出现退款查询时还没处理成功，后面又处理成功的情况，建议商户在退款发起后间隔10秒以上再发起退款查询请求。
        /// </summary>
        [XmlElement("refund_status")]
        public string RefundStatus { get; set; }

        /// <summary>
        /// 本次商户实际退回金额；单位：元。 默认不返回该信息，需要在入参的query_options中指定"refund_detail_item_list"值时才返回该字段信息。
        /// </summary>
        [XmlElement("send_back_fee")]
        public string SendBackFee { get; set; }

        /// <summary>
        /// 该笔退款所对应的交易的订单金额。单位：元。
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
