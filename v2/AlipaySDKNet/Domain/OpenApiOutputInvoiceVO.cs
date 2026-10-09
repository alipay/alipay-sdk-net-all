using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenApiOutputInvoiceVO Data Structure.
    /// </summary>
    [Serializable]
    public class OpenApiOutputInvoiceVO : AopObject
    {
        /// <summary>
        /// 发票附件名称
        /// </summary>
        [XmlElement("attachment_name")]
        public string AttachmentName { get; set; }

        /// <summary>
        /// 发票附件key
        /// </summary>
        [XmlElement("attachment_oss_key")]
        public string AttachmentOssKey { get; set; }

        /// <summary>
        /// 购方公司的地址
        /// </summary>
        [XmlElement("buyer_address")]
        public string BuyerAddress { get; set; }

        /// <summary>
        /// 购方银行名称
        /// </summary>
        [XmlElement("buyer_bank_account")]
        public string BuyerBankAccount { get; set; }

        /// <summary>
        /// 购方开户行名称
        /// </summary>
        [XmlElement("buyer_bank_name")]
        public string BuyerBankName { get; set; }

        /// <summary>
        /// 购方发票抬头
        /// </summary>
        [XmlElement("buyer_invoice_title")]
        public string BuyerInvoiceTitle { get; set; }

        /// <summary>
        /// 购方角色id
        /// </summary>
        [XmlElement("buyer_ip_role_id")]
        public string BuyerIpRoleId { get; set; }

        /// <summary>
        /// 购方mid
        /// </summary>
        [XmlElement("buyer_mid")]
        public string BuyerMid { get; set; }

        /// <summary>
        /// 购方公司税号
        /// </summary>
        [XmlElement("buyer_tax_no")]
        public string BuyerTaxNo { get; set; }

        /// <summary>
        /// 购方公司电话
        /// </summary>
        [XmlElement("buyer_telephone")]
        public string BuyerTelephone { get; set; }

        /// <summary>
        /// 是否可以关联账单 true：可以 false：不可以
        /// </summary>
        [XmlElement("can_link")]
        public bool CanLink { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        [XmlElement("creator")]
        public string Creator { get; set; }

        /// <summary>
        /// 开票人
        /// </summary>
        [XmlElement("drawer")]
        public string Drawer { get; set; }

        /// <summary>
        /// 电子发票文件地址
        /// </summary>
        [XmlElement("elc_invoice_url")]
        public string ElcInvoiceUrl { get; set; }

        /// <summary>
        /// 发票认证时间
        /// </summary>
        [XmlElement("gmt_auth")]
        public string GmtAuth { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 最后修改时间
        /// </summary>
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 发票关联时间
        /// </summary>
        [XmlElement("gmt_relevant")]
        public string GmtRelevant { get; set; }

        /// <summary>
        /// 票面金额
        /// </summary>
        [XmlElement("invoice_amt")]
        public MultiCurrencyMoneyOpenApi InvoiceAmt { get; set; }

        /// <summary>
        /// 开票渠道 01 线上,02 线下
        /// </summary>
        [XmlElement("invoice_channel")]
        public string InvoiceChannel { get; set; }

        /// <summary>
        /// 发票代码
        /// </summary>
        [XmlElement("invoice_code")]
        public string InvoiceCode { get; set; }

        /// <summary>
        /// 开票日期 格式(yyyyMMdd)
        /// </summary>
        [XmlElement("invoice_date")]
        public string InvoiceDate { get; set; }

        /// <summary>
        /// 发票id
        /// </summary>
        [XmlElement("invoice_id")]
        public string InvoiceId { get; set; }

        /// <summary>
        /// 发票行列表
        /// </summary>
        [XmlArray("invoice_lines")]
        [XmlArrayItem("open_api_invoice_line_v_o")]
        public List<OpenApiInvoiceLineVO> InvoiceLines { get; set; }

        /// <summary>
        /// 发票介质 01 电子,02 纸质
        /// </summary>
        [XmlElement("invoice_material")]
        public string InvoiceMaterial { get; set; }

        /// <summary>
        /// 发票号码
        /// </summary>
        [XmlElement("invoice_no")]
        public string InvoiceNo { get; set; }

        /// <summary>
        /// 发票票面备注
        /// </summary>
        [XmlElement("invoice_note")]
        public string InvoiceNote { get; set; }

        /// <summary>
        /// 发票状态 OutputInvoiceStatusEnum的code
        /// </summary>
        [XmlElement("invoice_status")]
        public string InvoiceStatus { get; set; }

        /// <summary>
        /// com.alipay.gfinvoice.facade.enums.InvoiceTypeEnum的code
        /// </summary>
        [XmlElement("invoice_type")]
        public string InvoiceType { get; set; }

        /// <summary>
        /// 是否能在线开票 Y 能, N 不能
        /// </summary>
        [XmlElement("is_online")]
        public string IsOnline { get; set; }

        /// <summary>
        /// 是否红字 Y红字 N蓝字
        /// </summary>
        [XmlElement("is_red")]
        public string IsRed { get; set; }

        /// <summary>
        /// 最后一次操作人
        /// </summary>
        [XmlElement("last_moder")]
        public string LastModer { get; set; }

        /// <summary>
        /// 已关联账单金额，无账单发票后续关联账单有该值
        /// </summary>
        [XmlElement("linked_amt")]
        public MultiCurrencyMoneyOpenApi LinkedAmt { get; set; }

        /// <summary>
        /// 邮寄状态
        /// </summary>
        [XmlElement("mail_status")]
        public string MailStatus { get; set; }

        /// <summary>
        /// 申请原因|申请备注
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 是否是无账单发票 Y：是  N：不是
        /// </summary>
        [XmlElement("no_bill_invoice_flag")]
        public string NoBillInvoiceFlag { get; set; }

        /// <summary>
        /// 收款人
        /// </summary>
        [XmlElement("payee")]
        public string Payee { get; set; }

        /// <summary>
        /// 形式发票Html
        /// </summary>
        [XmlElement("proforma_invoice_html")]
        public string ProformaInvoiceHtml { get; set; }

        /// <summary>
        /// 最近一次邮寄ID
        /// </summary>
        [XmlElement("recent_mail_id")]
        public string RecentMailId { get; set; }

        /// <summary>
        /// 红冲金额
        /// </summary>
        [XmlElement("red_amt")]
        public MultiCurrencyMoneyOpenApi RedAmt { get; set; }

        /// <summary>
        /// 红冲税务通知单号
        /// </summary>
        [XmlElement("red_notice_no")]
        public string RedNoticeNo { get; set; }

        /// <summary>
        /// 复核人
        /// </summary>
        [XmlElement("reviewer")]
        public string Reviewer { get; set; }

        /// <summary>
        /// 销方注册地
        /// </summary>
        [XmlElement("seller_address")]
        public string SellerAddress { get; set; }

        /// <summary>
        /// 销方银行账号
        /// </summary>
        [XmlElement("seller_bank_account")]
        public string SellerBankAccount { get; set; }

        /// <summary>
        /// 销方开户行名称
        /// </summary>
        [XmlElement("seller_bank_name")]
        public string SellerBankName { get; set; }

        /// <summary>
        /// 销方公司名称
        /// </summary>
        [XmlElement("seller_company_name")]
        public string SellerCompanyName { get; set; }

        /// <summary>
        /// 销方机构id
        /// </summary>
        [XmlElement("seller_inst_id")]
        public string SellerInstId { get; set; }

        /// <summary>
        /// 销方税号
        /// </summary>
        [XmlElement("seller_tax_no")]
        public string SellerTaxNo { get; set; }

        /// <summary>
        /// 销方公司电话
        /// </summary>
        [XmlElement("seller_telephone")]
        public string SellerTelephone { get; set; }

        /// <summary>
        /// 税额
        /// </summary>
        [XmlElement("tax_amt")]
        public MultiCurrencyMoneyOpenApi TaxAmt { get; set; }

        /// <summary>
        /// 形式发票模板url
        /// </summary>
        [XmlElement("template_url")]
        public string TemplateUrl { get; set; }

        /// <summary>
        /// 租户id
        /// </summary>
        [XmlElement("tnt_inst_id")]
        public string TntInstId { get; set; }
    }
}
