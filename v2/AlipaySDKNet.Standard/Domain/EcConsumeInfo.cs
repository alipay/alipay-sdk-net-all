using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EcConsumeInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EcConsumeInfo : AopObject
    {
        /// <summary>
        /// 共同账户ID
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 协议出资支付宝账号
        /// </summary>
        [XmlElement("agreement_peer_payer_id")]
        public string AgreementPeerPayerId { get; set; }

        /// <summary>
        /// 员工优惠金额，单位：元
        /// </summary>
        [XmlElement("benefit_amount")]
        public string BenefitAmount { get; set; }

        /// <summary>
        /// 外部交易流水号
        /// </summary>
        [XmlElement("biz_out_no")]
        public string BizOutNo { get; set; }

        /// <summary>
        /// 账单分类名称，如餐饮等
        /// </summary>
        [XmlElement("category_name")]
        public string CategoryName { get; set; }

        /// <summary>
        /// 账单金额，单位：元，不包含营销资产
        /// </summary>
        [XmlElement("consume_amount")]
        public string ConsumeAmount { get; set; }

        /// <summary>
        /// 账单业务类型 -因公支付：EC_PAY -因公收款：EC_CLLCT
        /// </summary>
        [XmlElement("consume_biz_type")]
        public string ConsumeBizType { get; set; }

        /// <summary>
        /// 员工消费记账分类： "cater": "餐饮" "purchase": "采购" "trip": "出行" "train": "培训" "entertainment": "娱乐" "hotel": "酒店" "pay": "缴费" "rent": "房租" "other": "其他"
        /// </summary>
        [XmlElement("consume_category")]
        public string ConsumeCategory { get; set; }

        /// <summary>
        /// 订单原价，单位：元，包含营销资产
        /// </summary>
        [XmlElement("consume_fee_with_discount")]
        public string ConsumeFeeWithDiscount { get; set; }

        /// <summary>
        /// 员工消费记账备注
        /// </summary>
        [XmlElement("consume_memo")]
        public string ConsumeMemo { get; set; }

        /// <summary>
        /// 商户收款时传的商品备注说明，在账单内进行表达
        /// </summary>
        [XmlElement("consume_title")]
        public string ConsumeTitle { get; set; }

        /// <summary>
        /// 账单类型 -消费账单：CONSUME -退款账单：REFUND -转账账单：TRANSFER
        /// </summary>
        [XmlElement("consume_type")]
        public string ConsumeType { get; set; }

        /// <summary>
        /// 员工账号ID
        /// </summary>
        [XmlElement("employee_id")]
        public string EmployeeId { get; set; }

        /// <summary>
        /// 企业ID
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 使用规则ID
        /// </summary>
        [XmlElement("expense_rule_group_id")]
        public string ExpenseRuleGroupId { get; set; }

        /// <summary>
        /// 费用场景
        /// </summary>
        [XmlElement("expense_scene_code")]
        public string ExpenseSceneCode { get; set; }

        /// <summary>
        /// 费用类型
        /// </summary>
        [XmlElement("expense_type")]
        public string ExpenseType { get; set; }

        /// <summary>
        /// 费用类型子类目
        /// </summary>
        [XmlElement("expense_type_sub_category")]
        public string ExpenseTypeSubCategory { get; set; }

        /// <summary>
        /// 账单扩展信息，JsonMap格式，以下信息可组合返回，"SUMMARY_INFO"表示"账单汇总信息"，"MERCHANT_EXTEND_INFO"表示"商户信息"，"TERMINAL_INFO"表示"终端设备信息"，"BENEFIT_INFO"表示"员工优惠信息"，"CONSUMPTION_LOCATION"表示"消费上报位置"，"THIRD_PARTY_PAYMENT_INFO"表示"代收款详情"，"REIMBURSEMENT_INFO"表示"审批单信息"
        /// </summary>
        [XmlElement("ext_infos")]
        public string ExtInfos { get; set; }

        /// <summary>
        /// 出资模式 个人出资：PERSONAL 企业出资：ENTERPRISE 三方垫资合作伙伴出资：TP 记账：ACCOUNTING
        /// </summary>
        [XmlElement("fund_biz_type")]
        public string FundBizType { get; set; }

        /// <summary>
        /// 账单创建时间，格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("gmt_biz_create")]
        public string GmtBizCreate { get; set; }

        /// <summary>
        /// 账单支付时间，格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("gmt_receive_pay")]
        public string GmtReceivePay { get; set; }

        /// <summary>
        /// 开票模式 企业汇总开：ENTERPRISE_AUTO_BATCH
        /// </summary>
        [XmlElement("invoice_open_mode")]
        public string InvoiceOpenMode { get; set; }

        /// <summary>
        /// 商户ID
        /// </summary>
        [XmlElement("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 商户名称
        /// </summary>
        [XmlElement("merchant_name")]
        public string MerchantName { get; set; }

        /// <summary>
        /// 员工支付宝UID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 收款方全称（如果是个人会显示脱敏后的名称）
        /// </summary>
        [XmlElement("opposite_full_name")]
        public string OppositeFullName { get; set; }

        /// <summary>
        /// 订单完结标识，0标识“未完结”，1标识“已完结”
        /// </summary>
        [XmlElement("order_complete_label")]
        public string OrderCompleteLabel { get; set; }

        /// <summary>
        /// 2022-01-01 01:01:02 订单完结时间
        /// </summary>
        [XmlElement("order_complete_time")]
        public string OrderCompleteTime { get; set; }

        /// <summary>
        /// 交易流水号
        /// </summary>
        [XmlElement("pay_no")]
        public string PayNo { get; set; }

        /// <summary>
        /// 付款方卡号
        /// </summary>
        [XmlElement("payer_card_no")]
        public string PayerCardNo { get; set; }

        /// <summary>
        /// 付款方登录账号
        /// </summary>
        [XmlElement("payer_logon_id")]
        public string PayerLogonId { get; set; }

        /// <summary>
        /// 付款方名称
        /// </summary>
        [XmlElement("payer_name")]
        public string PayerName { get; set; }

        /// <summary>
        /// 企业代付金额，单位：元
        /// </summary>
        [XmlElement("peer_pay_amount")]
        public string PeerPayAmount { get; set; }

        /// <summary>
        /// 实际出资支付宝账号
        /// </summary>
        [XmlElement("peer_payer_card_no")]
        public string PeerPayerCardNo { get; set; }

        /// <summary>
        /// 消费账单企业代付部分退款金额，单位：元。退款账单该值无意义，值为0。
        /// </summary>
        [XmlElement("peer_refund_amount")]
        public string PeerRefundAmount { get; set; }

        /// <summary>
        /// 该字段只对因公付交易生效，默认为INIT。当消费账单有退款，该值会变为REFUND_PART或REFUND_FULL；退款账单该值无意义，为初始值INIT。 未退款：INIT 部分退款：REFUND_PART， 全额退款：REFUND_FULL
        /// </summary>
        [XmlElement("peer_refund_status")]
        public string PeerRefundStatus { get; set; }

        /// <summary>
        /// 消费账单退款金额，单位：元。退款账单该值无意义，值为0。
        /// </summary>
        [XmlElement("refund_amount")]
        public string RefundAmount { get; set; }

        /// <summary>
        /// 当消费账单有退款，该值会变为REFUND_PART或REFUND_FULL；退款账单该值无意义，为初始值INIT。
        /// </summary>
        [XmlElement("refund_status")]
        public string RefundStatus { get; set; }

        /// <summary>
        /// 退款账单关联的消费账单交易流水号，退款账单才有值
        /// </summary>
        [XmlElement("related_pay_no")]
        public string RelatedPayNo { get; set; }

        /// <summary>
        /// 账单场景 TAKE_AWAY：外卖 METRO：地铁 OTHER：其他
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 卖家ID
        /// </summary>
        [XmlElement("seller_id")]
        public string SellerId { get; set; }

        /// <summary>
        /// 门店ID
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 外部门店ID
        /// </summary>
        [XmlElement("store_id")]
        public string StoreId { get; set; }

        /// <summary>
        /// 汇总批次ID
        /// </summary>
        [XmlElement("summary_apply_id")]
        public string SummaryApplyId { get; set; }

        /// <summary>
        /// 员工支付宝UID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
