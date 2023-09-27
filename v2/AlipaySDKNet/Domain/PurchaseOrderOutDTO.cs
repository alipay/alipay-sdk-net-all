using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PurchaseOrderOutDTO Data Structure.
    /// </summary>
    [Serializable]
    public class PurchaseOrderOutDTO : AopObject
    {
        /// <summary>
        /// 是否对供应商金额可见
        /// </summary>
        [XmlElement("amount_visible")]
        public bool AmountVisible { get; set; }

        /// <summary>
        /// 支付宝账号
        /// </summary>
        [XmlElement("antgroup_account")]
        public string AntgroupAccount { get; set; }

        /// <summary>
        /// 银行账户
        /// </summary>
        [XmlElement("bank_account")]
        public string BankAccount { get; set; }

        /// <summary>
        /// 开户行
        /// </summary>
        [XmlElement("bank_branch_name")]
        public string BankBranchName { get; set; }

        /// <summary>
        /// 业务类型
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 采购员员工编码
        /// </summary>
        [XmlElement("buyer")]
        public string Buyer { get; set; }

        /// <summary>
        /// 采购员部门
        /// </summary>
        [XmlElement("buyer_dept_code")]
        public string BuyerDeptCode { get; set; }

        /// <summary>
        /// 采购经理员工编码
        /// </summary>
        [XmlElement("buyer_manager")]
        public string BuyerManager { get; set; }

        /// <summary>
        /// 采购员采购组织
        /// </summary>
        [XmlElement("buyer_purchase_org_id")]
        public long BuyerPurchaseOrgId { get; set; }

        /// <summary>
        /// 业务公司
        /// </summary>
        [XmlElement("company_code")]
        public string CompanyCode { get; set; }

        /// <summary>
        /// 公司名称
        /// </summary>
        [XmlElement("company_name")]
        public string CompanyName { get; set; }

        /// <summary>
        /// 字段配置信息
        /// </summary>
        [XmlElement("config_out_dto")]
        public ConfigOutDTO ConfigOutDto { get; set; }

        /// <summary>
        /// 被供应商确认： -- null 无需确认（默认）； -- y 已确认； -- n 待确认；
        /// </summary>
        [XmlElement("confirmed")]
        public string Confirmed { get; set; }

        /// <summary>
        /// 合同编号
        /// </summary>
        [XmlElement("contract_number")]
        public string ContractNumber { get; set; }

        /// <summary>
        /// ContractOrderSendLogDTO
        /// </summary>
        [XmlArray("contract_order_send_log_dto_list")]
        [XmlArrayItem("contract_order_send_log_d_t_o")]
        public List<ContractOrderSendLogDTO> ContractOrderSendLogDtoList { get; set; }

        /// <summary>
        /// 合同类型
        /// </summary>
        [XmlElement("contract_type")]
        public string ContractType { get; set; }

        /// <summary>
        /// 创建者
        /// </summary>
        [XmlElement("creator")]
        public string Creator { get; set; }

        /// <summary>
        /// 币种
        /// </summary>
        [XmlElement("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 数据来源
        /// </summary>
        [XmlElement("data_source")]
        public string DataSource { get; set; }

        /// <summary>
        /// 需求方采购组织
        /// </summary>
        [XmlElement("demander_purchase_org_id")]
        public long DemanderPurchaseOrgId { get; set; }

        /// <summary>
        /// 订单描述
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 订单有效期区间
        /// </summary>
        [XmlElement("effect_date_range")]
        public DateRangeDTO EffectDateRange { get; set; }

        /// <summary>
        /// 订单有效期区间end
        /// </summary>
        [XmlElement("effect_date_range_end")]
        public string EffectDateRangeEnd { get; set; }

        /// <summary>
        /// 订单有效期区间_start
        /// </summary>
        [XmlElement("effect_date_range_start")]
        public string EffectDateRangeStart { get; set; }

        /// <summary>
        /// 订单生效时间
        /// </summary>
        [XmlElement("effect_time")]
        public string EffectTime { get; set; }

        /// <summary>
        /// 邮件发送状态
        /// </summary>
        [XmlElement("email_status")]
        public string EmailStatus { get; set; }

        /// <summary>
        /// 汇率
        /// </summary>
        [XmlElement("exchange_rate")]
        public string ExchangeRate { get; set; }

        /// <summary>
        /// 外部订单编号
        /// </summary>
        [XmlElement("external_po_number")]
        public string ExternalPoNumber { get; set; }

        /// <summary>
        /// 文件
        /// </summary>
        [XmlArray("file_list")]
        [XmlArrayItem("aecp_file_d_t_o")]
        public List<AecpFileDTO> FileList { get; set; }

        /// <summary>
        /// 附件
        /// </summary>
        [XmlElement("files")]
        public string Files { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 是否已有电子章
        /// </summary>
        [XmlElement("has_electronic_sign")]
        public bool HasElectronicSign { get; set; }

        /// <summary>
        /// 订单ID
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 已开票总金额
        /// </summary>
        [XmlElement("invoiced_amount")]
        public string InvoicedAmount { get; set; }

        /// <summary>
        /// 是否支付宝
        /// </summary>
        [XmlElement("is_ant_group")]
        public bool IsAntGroup { get; set; }

        /// <summary>
        /// 是否现金支付
        /// </summary>
        [XmlElement("is_cash_pay")]
        public bool IsCashPay { get; set; }

        /// <summary>
        /// 是否支票支付
        /// </summary>
        [XmlElement("is_cheque_pay")]
        public bool IsChequePay { get; set; }

        /// <summary>
        /// 是否按明细发货
        /// </summary>
        [XmlElement("is_delivery_detail")]
        public bool IsDeliveryDetail { get; set; }

        /// <summary>
        /// 是否到期提醒
        /// </summary>
        [XmlElement("is_expire_remind")]
        public bool IsExpireRemind { get; set; }

        /// <summary>
        /// 订单明细
        /// </summary>
        [XmlArray("item_list")]
        [XmlArrayItem("purchase_order_item_out_d_t_o")]
        public List<PurchaseOrderItemOutDTO> ItemList { get; set; }

        /// <summary>
        /// 修改者
        /// </summary>
        [XmlElement("modifier")]
        public string Modifier { get; set; }

        /// <summary>
        /// 无合同理由
        /// </summary>
        [XmlElement("no_contract_reason")]
        public string NoContractReason { get; set; }

        /// <summary>
        /// 下单途径
        /// </summary>
        [XmlElement("order_channel")]
        public string OrderChannel { get; set; }

        /// <summary>
        /// 原始币种
        /// </summary>
        [XmlElement("origin_currency")]
        public string OriginCurrency { get; set; }

        /// <summary>
        /// 阿里租户特有：财务公司代码
        /// </summary>
        [XmlElement("ou_code")]
        public string OuCode { get; set; }

        /// <summary>
        /// 已付总金额
        /// </summary>
        [XmlElement("paid_amount")]
        public string PaidAmount { get; set; }

        /// <summary>
        /// 收款方户名
        /// </summary>
        [XmlElement("payee_account_name")]
        public string PayeeAccountName { get; set; }

        /// <summary>
        /// 收款方账户id
        /// </summary>
        [XmlElement("payee_bank_id")]
        public string PayeeBankId { get; set; }

        /// <summary>
        /// 收款方ID
        /// </summary>
        [XmlElement("payee_id")]
        public string PayeeId { get; set; }

        /// <summary>
        /// 收款方名称
        /// </summary>
        [XmlElement("payee_name")]
        public string PayeeName { get; set; }

        /// <summary>
        /// 付款计划
        /// </summary>
        [XmlElement("payment_plan_dto")]
        public PaymentPlanDTO PaymentPlanDto { get; set; }

        /// <summary>
        /// 开票信息
        /// </summary>
        [XmlElement("po_billable_info_dto")]
        public PoBillableInfoDto PoBillableInfoDto { get; set; }

        /// <summary>
        /// 订单编号
        /// </summary>
        [XmlElement("po_number")]
        public string PoNumber { get; set; }

        /// <summary>
        /// 报价审批通过时间
        /// </summary>
        [XmlElement("quotation_approved_time")]
        public string QuotationApprovedTime { get; set; }

        /// <summary>
        /// 报价单号
        /// </summary>
        [XmlElement("quotation_number")]
        public string QuotationNumber { get; set; }

        /// <summary>
        /// 复用共框合同编码
        /// </summary>
        [XmlElement("reusable_contract_code")]
        public string ReusableContractCode { get; set; }

        /// <summary>
        /// 来源系统类型
        /// </summary>
        [XmlElement("source_type")]
        public string SourceType { get; set; }

        /// <summary>
        /// 订单状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 结构化明细业务场景
        /// </summary>
        [XmlElement("structured_detail_biz_scene")]
        public string StructuredDetailBizScene { get; set; }

        /// <summary>
        /// 供应商ID
        /// </summary>
        [XmlElement("supplier_id")]
        public string SupplierId { get; set; }

        /// <summary>
        /// 供应商链接
        /// </summary>
        [XmlElement("supplier_link")]
        public LinkDTO SupplierLink { get; set; }

        /// <summary>
        /// 租户ID
        /// </summary>
        [XmlElement("tenant_id")]
        public long TenantId { get; set; }

        /// <summary>
        /// 已满足付款条件
        /// </summary>
        [XmlElement("to_paid_amount")]
        public string ToPaidAmount { get; set; }

        /// <summary>
        /// 订单总金额
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }
    }
}
