using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InputInvoiceOpenApiDTO Data Structure.
    /// </summary>
    [Serializable]
    public class InputInvoiceOpenApiDTO : AopObject
    {
        /// <summary>
        /// 发票总金额，币种单位见currency字段
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 是否海外某些国家的发票使用
        /// </summary>
        [XmlElement("authorized_dealer")]
        public string AuthorizedDealer { get; set; }

        /// <summary>
        /// 业务类型
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 勾选状态
        /// </summary>
        [XmlElement("certify_status")]
        public string CertifyStatus { get; set; }

        /// <summary>
        /// 勾选状态描述
        /// </summary>
        [XmlElement("certify_status_memo")]
        public string CertifyStatusMemo { get; set; }

        /// <summary>
        /// 勾选成功时间
        /// </summary>
        [XmlElement("certify_time")]
        public string CertifyTime { get; set; }

        /// <summary>
        /// 勾选成功人
        /// </summary>
        [XmlElement("certify_user")]
        public string CertifyUser { get; set; }

        /// <summary>
        /// 验真状态: 未验真，验真中, 验真成功, 验真失败
        /// </summary>
        [XmlElement("check_status")]
        public string CheckStatus { get; set; }

        /// <summary>
        /// 验真状态描述
        /// </summary>
        [XmlElement("check_status_memo")]
        public string CheckStatusMemo { get; set; }

        /// <summary>
        /// 校验码
        /// </summary>
        [XmlElement("check_sum")]
        public string CheckSum { get; set; }

        /// <summary>
        /// 验真时间
        /// </summary>
        [XmlElement("check_time")]
        public string CheckTime { get; set; }

        /// <summary>
        /// 密文
        /// </summary>
        [XmlElement("cipher_text")]
        public string CipherText { get; set; }

        /// <summary>
        /// ou
        /// </summary>
        [XmlElement("company_code")]
        public string CompanyCode { get; set; }

        /// <summary>
        /// 币种
        /// </summary>
        [XmlElement("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 作废时间
        /// </summary>
        [XmlElement("discard_time")]
        public string DiscardTime { get; set; }

        /// <summary>
        /// 分发状态: 未分发，分发中，已分发，撤回中，分发失败
        /// </summary>
        [XmlElement("distribute_status")]
        public string DistributeStatus { get; set; }

        /// <summary>
        /// 分发状态描述
        /// </summary>
        [XmlElement("distribute_status_memo")]
        public string DistributeStatusMemo { get; set; }

        /// <summary>
        /// 有效税额,币种单位见currency字段
        /// </summary>
        [XmlElement("effective_tax_amount")]
        public string EffectiveTaxAmount { get; set; }

        /// <summary>
        /// 是电子发票的情况下，电子发票类型: PDF/OFD/IMG
        /// </summary>
        [XmlElement("electronic_type")]
        public string ElectronicType { get; set; }

        /// <summary>
        /// 不含税金额,币种单位见currency字段
        /// </summary>
        [XmlElement("excluding_tax_amount")]
        public string ExcludingTaxAmount { get; set; }

        /// <summary>
        /// 发票id
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 影像的原始文件名称
        /// </summary>
        [XmlElement("image_file_name")]
        public string ImageFileName { get; set; }

        /// <summary>
        /// 影像ID
        /// </summary>
        [XmlElement("image_id")]
        public string ImageId { get; set; }

        /// <summary>
        /// 影像url
        /// </summary>
        [XmlElement("image_url")]
        public string ImageUrl { get; set; }

        /// <summary>
        /// 发票代码
        /// </summary>
        [XmlElement("invoice_code")]
        public string InvoiceCode { get; set; }

        /// <summary>
        /// 开票日期,格式yyyyMMdd
        /// </summary>
        [XmlElement("invoice_date")]
        public string InvoiceDate { get; set; }

        /// <summary>
        /// 发票开具类型，RED红票；BLUE蓝票；
        /// </summary>
        [XmlElement("invoice_issue_type")]
        public string InvoiceIssueType { get; set; }

        /// <summary>
        /// 发票行
        /// </summary>
        [XmlArray("invoice_line")]
        [XmlArrayItem("input_invoice_line_open_api_d_t_o")]
        public List<InputInvoiceLineOpenApiDTO> InvoiceLine { get; set; }

        /// <summary>
        /// 发票介质：PAPER纸质票、ELECTRONIC电子票
        /// </summary>
        [XmlElement("invoice_material")]
        public string InvoiceMaterial { get; set; }

        /// <summary>
        /// 发票介质描述
        /// </summary>
        [XmlElement("invoice_material_memo")]
        public string InvoiceMaterialMemo { get; set; }

        /// <summary>
        /// 发票号码
        /// </summary>
        [XmlElement("invoice_no")]
        public string InvoiceNo { get; set; }

        /// <summary>
        /// 发票备注
        /// </summary>
        [XmlElement("invoice_remark")]
        public string InvoiceRemark { get; set; }

        /// <summary>
        /// 发票类型，VAT_SPE专票；VAT_COMM普票
        /// </summary>
        [XmlElement("invoice_type")]
        public string InvoiceType { get; set; }

        /// <summary>
        /// 发票类型描述
        /// </summary>
        [XmlElement("invoice_type_memo")]
        public string InvoiceTypeMemo { get; set; }

        /// <summary>
        /// 开票国家类型(MAINLAND:大陆，NON_MAINLAND:非大陆，ALL_OVER_WORLD:全世界)
        /// </summary>
        [XmlElement("issue_country_type")]
        public string IssueCountryType { get; set; }

        /// <summary>
        /// 代开销方名称
        /// </summary>
        [XmlElement("issued_seller_name")]
        public string IssuedSellerName { get; set; }

        /// <summary>
        /// 代开单位税号
        /// </summary>
        [XmlElement("issued_tax_no")]
        public string IssuedTaxNo { get; set; }

        /// <summary>
        /// 机器编码
        /// </summary>
        [XmlElement("machine_code")]
        public string MachineCode { get; set; }

        /// <summary>
        /// 购方开户行及账号
        /// </summary>
        [XmlElement("purchaser_bank_info")]
        public string PurchaserBankInfo { get; set; }

        /// <summary>
        /// 购方代码
        /// </summary>
        [XmlElement("purchaser_code")]
        public string PurchaserCode { get; set; }

        /// <summary>
        /// 购方地址及电话
        /// </summary>
        [XmlElement("purchaser_contact_info")]
        public string PurchaserContactInfo { get; set; }

        /// <summary>
        /// 购方国家编码
        /// </summary>
        [XmlElement("purchaser_country_code")]
        public string PurchaserCountryCode { get; set; }

        /// <summary>
        /// 购方名称
        /// </summary>
        [XmlElement("purchaser_name")]
        public string PurchaserName { get; set; }

        /// <summary>
        /// 购方地区编码
        /// </summary>
        [XmlElement("purchaser_region_code")]
        public string PurchaserRegionCode { get; set; }

        /// <summary>
        /// 购方税号
        /// </summary>
        [XmlElement("purchaser_tax_no")]
        public string PurchaserTaxNo { get; set; }

        /// <summary>
        /// 二维码密文
        /// </summary>
        [XmlElement("qr_code_cipher_text")]
        public string QrCodeCipherText { get; set; }

        /// <summary>
        /// 二维码标志
        /// </summary>
        [XmlElement("qr_code_flag")]
        public string QrCodeFlag { get; set; }

        /// <summary>
        /// 登记时，选业务身份，可空
        /// </summary>
        [XmlElement("reg_biz_identity_code")]
        public string RegBizIdentityCode { get; set; }

        /// <summary>
        /// 登记时，所选的OU
        /// </summary>
        [XmlElement("reg_biz_identity_ou")]
        public string RegBizIdentityOu { get; set; }

        /// <summary>
        /// 所属的平台
        /// </summary>
        [XmlElement("reg_platform_code")]
        public string RegPlatformCode { get; set; }

        /// <summary>
        /// 登记状态
        /// </summary>
        [XmlElement("reg_status")]
        public string RegStatus { get; set; }

        /// <summary>
        /// 登记状态描述
        /// </summary>
        [XmlElement("reg_status_memo")]
        public string RegStatusMemo { get; set; }

        /// <summary>
        /// 登记成功时间
        /// </summary>
        [XmlElement("reg_time")]
        public string RegTime { get; set; }

        /// <summary>
        /// 登记人
        /// </summary>
        [XmlElement("reg_user")]
        public string RegUser { get; set; }

        /// <summary>
        /// 登记通道
        /// </summary>
        [XmlElement("register_channel")]
        public string RegisterChannel { get; set; }

        /// <summary>
        /// 登记通道描述
        /// </summary>
        [XmlElement("register_channel_memo")]
        public string RegisterChannelMemo { get; set; }

        /// <summary>
        /// 关联单据号
        /// </summary>
        [XmlElement("related_order")]
        public string RelatedOrder { get; set; }

        /// <summary>
        /// 业务来源,如智付、关联交易、报销、银泰AP、盒马AP、菜鸟AP等
        /// </summary>
        [XmlElement("related_system")]
        public string RelatedSystem { get; set; }

        /// <summary>
        /// 退票时间
        /// </summary>
        [XmlElement("return_time")]
        public string ReturnTime { get; set; }

        /// <summary>
        /// 退票人
        /// </summary>
        [XmlElement("return_user")]
        public string ReturnUser { get; set; }

        /// <summary>
        /// 退票快递公司
        /// </summary>
        [XmlElement("return_waybill_company")]
        public string ReturnWaybillCompany { get; set; }

        /// <summary>
        /// 退票快递单号
        /// </summary>
        [XmlElement("return_waybill_no")]
        public string ReturnWaybillNo { get; set; }

        /// <summary>
        /// 扫描帐号
        /// </summary>
        [XmlElement("scan_account")]
        public string ScanAccount { get; set; }

        /// <summary>
        /// 销方开户行及账号
        /// </summary>
        [XmlElement("seller_bank_info")]
        public string SellerBankInfo { get; set; }

        /// <summary>
        /// 销方代码
        /// </summary>
        [XmlElement("seller_code")]
        public string SellerCode { get; set; }

        /// <summary>
        /// 销方地址及电话
        /// </summary>
        [XmlElement("seller_contact_info")]
        public string SellerContactInfo { get; set; }

        /// <summary>
        /// 销方国家编码
        /// </summary>
        [XmlElement("seller_country_code")]
        public string SellerCountryCode { get; set; }

        /// <summary>
        /// sellerName
        /// </summary>
        [XmlElement("seller_name")]
        public string SellerName { get; set; }

        /// <summary>
        /// 销方地区编码
        /// </summary>
        [XmlElement("seller_region_code")]
        public string SellerRegionCode { get; set; }

        /// <summary>
        /// 销方税号
        /// </summary>
        [XmlElement("seller_tax_no")]
        public string SellerTaxNo { get; set; }

        /// <summary>
        /// 税额，币种单位见currency字段
        /// </summary>
        [XmlElement("tax_amount")]
        public string TaxAmount { get; set; }

        /// <summary>
        /// 认证所属期
        /// </summary>
        [XmlElement("tax_period")]
        public string TaxPeriod { get; set; }

        /// <summary>
        /// 税率
        /// </summary>
        [XmlElement("tax_rate")]
        public long TaxRate { get; set; }
    }
}
