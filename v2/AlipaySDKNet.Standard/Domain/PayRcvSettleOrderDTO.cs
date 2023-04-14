using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PayRcvSettleOrderDTO Data Structure.
    /// </summary>
    [Serializable]
    public class PayRcvSettleOrderDTO : AopObject
    {
        /// <summary>
        /// 需结算金额
        /// </summary>
        [XmlElement("amount")]
        public MultiCurrencyMoneyOpenApi Amount { get; set; }

        /// <summary>
        /// 端产品码
        /// </summary>
        [XmlElement("ant_pd_code")]
        public string AntPdCode { get; set; }

        /// <summary>
        /// 收付款引擎申请单id
        /// </summary>
        [XmlElement("apply_id")]
        public string ApplyId { get; set; }

        /// <summary>
        /// 协议号
        /// </summary>
        [XmlElement("arrangement_no")]
        public string ArrangementNo { get; set; }

        /// <summary>
        /// 业务产品码
        /// </summary>
        [XmlElement("biz_pd_code")]
        public string BizPdCode { get; set; }

        /// <summary>
        /// 结算时点
        /// </summary>
        [XmlElement("fund_settle_time")]
        public string FundSettleTime { get; set; }

        /// <summary>
        /// 结算资金模式
        /// </summary>
        [XmlElement("initiative_settle")]
        public string InitiativeSettle { get; set; }

        /// <summary>
        /// 机构
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 销售产品码的签约主体
        /// </summary>
        [XmlElement("ip_role_id")]
        public string IpRoleId { get; set; }

        /// <summary>
        /// 主体来源
        /// </summary>
        [XmlElement("ip_role_id_source")]
        public string IpRoleIdSource { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 结算单号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 付款时间
        /// </summary>
        [XmlElement("pay_date")]
        public string PayDate { get; set; }

        /// <summary>
        /// 收款支行
        /// </summary>
        [XmlElement("payee_account_branch_name")]
        public string PayeeAccountBranchName { get; set; }

        /// <summary>
        /// 收款人
        /// </summary>
        [XmlElement("payee_account_name")]
        public string PayeeAccountName { get; set; }

        /// <summary>
        /// 收款方账号
        /// </summary>
        [XmlElement("payee_account_no")]
        public string PayeeAccountNo { get; set; }

        /// <summary>
        /// 付款方账号类型
        /// </summary>
        [XmlElement("payee_account_type")]
        public string PayeeAccountType { get; set; }

        /// <summary>
        /// 收款方账号类型
        /// </summary>
        [XmlElement("payee_account_type_name")]
        public string PayeeAccountTypeName { get; set; }

        /// <summary>
        /// 方
        /// </summary>
        [XmlElement("payee_ip_role_id")]
        public string PayeeIpRoleId { get; set; }

        /// <summary>
        /// 付款方支行
        /// </summary>
        [XmlElement("payer_account_branch_name")]
        public string PayerAccountBranchName { get; set; }

        /// <summary>
        /// 付款人
        /// </summary>
        [XmlElement("payer_account_name")]
        public string PayerAccountName { get; set; }

        /// <summary>
        /// 付款方账号
        /// </summary>
        [XmlElement("payer_account_no")]
        public string PayerAccountNo { get; set; }

        /// <summary>
        /// 付款方账号类型
        /// </summary>
        [XmlElement("payer_account_type")]
        public string PayerAccountType { get; set; }

        /// <summary>
        /// 付款方账号类型名称
        /// </summary>
        [XmlElement("payer_account_type_name")]
        public string PayerAccountTypeName { get; set; }

        /// <summary>
        /// 结算付款方主体
        /// </summary>
        [XmlElement("payer_ip_role_id")]
        public string PayerIpRoleId { get; set; }

        /// <summary>
        /// 销售产品码
        /// </summary>
        [XmlElement("sales_product_code")]
        public string SalesProductCode { get; set; }

        /// <summary>
        /// 结算的业务类型
        /// </summary>
        [XmlElement("settle_biz_type")]
        public string SettleBizType { get; set; }

        /// <summary>
        /// 已结算金额
        /// </summary>
        [XmlElement("settled_amount")]
        public MultiCurrencyMoneyOpenApi SettledAmount { get; set; }

        /// <summary>
        /// 结算单状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 状态名称
        /// </summary>
        [XmlElement("status_name")]
        public string StatusName { get; set; }
    }
}
