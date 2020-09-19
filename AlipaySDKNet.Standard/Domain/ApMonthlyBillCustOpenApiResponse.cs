using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ApMonthlyBillCustOpenApiResponse Data Structure.
    /// </summary>
    [Serializable]
    public class ApMonthlyBillCustOpenApiResponse : AopObject
    {
        /// <summary>
        /// 分析维度1
        /// </summary>
        [XmlElement("analysis_dmsn_1")]
        public string AnalysisDmsn1 { get; set; }

        /// <summary>
        /// 分析维度2
        /// </summary>
        [XmlElement("analysis_dmsn_2")]
        public string AnalysisDmsn2 { get; set; }

        /// <summary>
        /// 分析维度3
        /// </summary>
        [XmlElement("analysis_dmsn_3")]
        public string AnalysisDmsn3 { get; set; }

        /// <summary>
        /// 分析维度4
        /// </summary>
        [XmlElement("analysis_dmsn_4")]
        public string AnalysisDmsn4 { get; set; }

        /// <summary>
        /// 合约号
        /// </summary>
        [XmlElement("ar_no")]
        public string ArNo { get; set; }

        /// <summary>
        /// 认证关联发票金额
        /// </summary>
        [XmlElement("auth_invoice_amt")]
        public MultiCurrencyMoneyOpenApi AuthInvoiceAmt { get; set; }

        /// <summary>
        /// 账单关联发票状态[01-未关联；02-部分关联；03-完全关联]
        /// </summary>
        [XmlElement("bill_invoice_link_status")]
        public string BillInvoiceLinkStatus { get; set; }

        /// <summary>
        /// 账单月份(yyyyMM)
        /// </summary>
        [XmlElement("bill_month")]
        public string BillMonth { get; set; }

        /// <summary>
        /// 月账单号
        /// </summary>
        [XmlElement("bill_no")]
        public string BillNo { get; set; }

        /// <summary>
        /// 业务类型
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 账单结束日期(yyyyMMdd)
        /// </summary>
        [XmlElement("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 止付金额
        /// </summary>
        [XmlElement("fbd_pay_amt")]
        public MultiCurrencyMoneyOpenApi FbdPayAmt { get; set; }

        /// <summary>
        /// 止付类型（通常为空）{"01":"客户级别止付","02":"用户级别止付","03":"账单级别止付","04":"用户产品级别止付","05":"客户产品级别止付","99":"未止付"}
        /// </summary>
        [XmlElement("fbd_pay_type")]
        public string FbdPayType { get; set; }

        /// <summary>
        /// 分支机构ID（OU标识）
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 关联发票金额
        /// </summary>
        [XmlElement("invoice_amt")]
        public MultiCurrencyMoneyOpenApi InvoiceAmt { get; set; }

        /// <summary>
        /// 签约对象PID
        /// </summary>
        [XmlElement("ip_role_id")]
        public string IpRoleId { get; set; }

        /// <summary>
        /// 结算对象名称
        /// </summary>
        [XmlElement("ip_role_name")]
        public string IpRoleName { get; set; }

        /// <summary>
        /// 签约对象MID（非商户时为空）
        /// </summary>
        [XmlElement("mid")]
        public string Mid { get; set; }

        /// <summary>
        /// 税损扣除后月账单可关联发票金额，无发票类型时，默认为0
        /// </summary>
        [XmlElement("new_can_invoice_amt")]
        public MultiCurrencyMoneyOpenApi NewCanInvoiceAmt { get; set; }

        /// <summary>
        /// 已付金额
        /// </summary>
        [XmlElement("paid_amt")]
        public MultiCurrencyMoneyOpenApi PaidAmt { get; set; }

        /// <summary>
        /// 付款渠道：银行账号 、支付宝账号、国际银行卡
        /// </summary>
        [XmlElement("pay_channel")]
        public string PayChannel { get; set; }

        /// <summary>
        /// 付款状态[01-待结算；02-部分结算；03-结算完成]
        /// </summary>
        [XmlElement("pay_status")]
        public string PayStatus { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        [XmlElement("pd_code")]
        public string PdCode { get; set; }

        /// <summary>
        /// 产品名称
        /// </summary>
        [XmlElement("pd_name")]
        public string PdName { get; set; }

        /// <summary>
        /// 计价标识
        /// </summary>
        [XmlElement("price_id")]
        public string PriceId { get; set; }

        /// <summary>
        /// 价格名
        /// </summary>
        [XmlElement("price_name")]
        public string PriceName { get; set; }

        /// <summary>
        /// 价格政策ID
        /// </summary>
        [XmlElement("price_policy_id")]
        public string PricePolicyId { get; set; }

        /// <summary>
        /// 价格政策名
        /// </summary>
        [XmlElement("price_policy_name")]
        public string PricePolicyName { get; set; }

        /// <summary>
        /// 客户可见账单金额 = 账单确认金额 + 汇总调整确认金额 + 明细调整确认金额
        /// </summary>
        [XmlElement("real_bill_amt")]
        public MultiCurrencyMoneyOpenApi RealBillAmt { get; set; }

        /// <summary>
        /// 结算类型，01-实时，02-后付，03-周期性
        /// </summary>
        [XmlElement("settle_type")]
        public string SettleType { get; set; }

        /// <summary>
        /// 账单开始日期(yyyyMMdd)
        /// </summary>
        [XmlElement("start_date")]
        public string StartDate { get; set; }

        /// <summary>
        /// 税额
        /// </summary>
        [XmlElement("tax_amt")]
        public MultiCurrencyMoneyOpenApi TaxAmt { get; set; }
    }
}
