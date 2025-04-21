using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InputInvoiceRegisterOpenApiDTO Data Structure.
    /// </summary>
    [Serializable]
    public class InputInvoiceRegisterOpenApiDTO : AopObject
    {
        /// <summary>
        /// 金额类,币种见currency字段
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 标识是否走主站登记链路
        /// </summary>
        [XmlElement("ant_group_register_flag")]
        public string AntGroupRegisterFlag { get; set; }

        /// <summary>
        /// 是否海外某些国家的发票使用
        /// </summary>
        [XmlElement("authorized_dealer")]
        public string AuthorizedDealer { get; set; }

        /// <summary>
        /// 表示是否需要勾选抵扣
        /// </summary>
        [XmlElement("certify_deduct_flag")]
        public string CertifyDeductFlag { get; set; }

        /// <summary>
        /// 校验码
        /// </summary>
        [XmlElement("check_sum")]
        public string CheckSum { get; set; }

        /// <summary>
        /// 密文
        /// </summary>
        [XmlElement("cipher_text")]
        public string CipherText { get; set; }

        /// <summary>
        /// 币种
        /// </summary>
        [XmlElement("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 发展基金
        /// </summary>
        [XmlElement("development_fund")]
        public string DevelopmentFund { get; set; }

        /// <summary>
        /// 有效税额，币种见currency字段
        /// </summary>
        [XmlElement("effective_tax_amount")]
        public string EffectiveTaxAmount { get; set; }

        /// <summary>
        /// 是电子发票的情况下，电子发票类型: PDF/OFD/IMG
        /// </summary>
        [XmlElement("electronic_type")]
        public string ElectronicType { get; set; }

        /// <summary>
        /// 不含税金额，币种见currency字段
        /// </summary>
        [XmlElement("excluding_tax_amount")]
        public string ExcludingTaxAmount { get; set; }

        /// <summary>
        /// 票价信息
        /// </summary>
        [XmlElement("fare")]
        public string Fare { get; set; }

        /// <summary>
        /// 文件下载http地址
        /// </summary>
        [XmlElement("file_download_http_url")]
        public string FileDownloadHttpUrl { get; set; }

        /// <summary>
        /// 燃油附加费
        /// </summary>
        [XmlElement("fuel_surcharge")]
        public string FuelSurcharge { get; set; }

        /// <summary>
        /// 全电票标签，根据具体发票类型传入
        /// </summary>
        [XmlElement("full_elc_flag")]
        public string FullElcFlag { get; set; }

        /// <summary>
        /// 影像原始文件名称
        /// </summary>
        [XmlElement("image_file_name")]
        public string ImageFileName { get; set; }

        /// <summary>
        /// 发票代码
        /// </summary>
        [XmlElement("invoice_code")]
        public string InvoiceCode { get; set; }

        /// <summary>
        /// 开票日期，格式：yyyyMMdd
        /// </summary>
        [XmlElement("invoice_date")]
        public string InvoiceDate { get; set; }

        /// <summary>
        /// 发票介质：PAPER纸质票、ELECTRONIC电子票
        /// </summary>
        [XmlElement("invoice_material")]
        public string InvoiceMaterial { get; set; }

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
        /// 发票类型
        /// </summary>
        [XmlElement("invoice_type")]
        public string InvoiceType { get; set; }

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
        /// 发票行
        /// </summary>
        [XmlArray("line_list")]
        [XmlArrayItem("input_invoice_line_register_open_api_d_t_o")]
        public List<InputInvoiceLineRegisterOpenApiDTO> LineList { get; set; }

        /// <summary>
        /// 机器编码
        /// </summary>
        [XmlElement("machine_code")]
        public string MachineCode { get; set; }

        /// <summary>
        /// 操作人
        /// </summary>
        [XmlElement("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 平台code
        /// </summary>
        [XmlElement("platform_code")]
        public string PlatformCode { get; set; }

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
        /// 税号
        /// </summary>
        [XmlElement("purchaser_tax_no")]
        public string PurchaserTaxNo { get; set; }

        /// <summary>
        /// 二维码标识
        /// </summary>
        [XmlElement("qr_code_flag")]
        public string QrCodeFlag { get; set; }

        /// <summary>
        /// 登记时所属的业务身份
        /// </summary>
        [XmlElement("reg_biz_identity_code")]
        public string RegBizIdentityCode { get; set; }

        /// <summary>
        /// 登记时所属的平台
        /// </summary>
        [XmlElement("reg_platform_code")]
        public string RegPlatformCode { get; set; }

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
        /// 关联单据号
        /// </summary>
        [XmlElement("related_order")]
        public string RelatedOrder { get; set; }

        /// <summary>
        /// 请求号
        /// </summary>
        [XmlElement("request_no")]
        public string RequestNo { get; set; }

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
        /// 销方名称
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
        /// 发票税额，币种见currency字段
        /// </summary>
        [XmlElement("tax_amount")]
        public string TaxAmount { get; set; }

        /// <summary>
        /// 税率
        /// </summary>
        [XmlElement("tax_rate")]
        public long TaxRate { get; set; }

        /// <summary>
        /// 运单号
        /// </summary>
        [XmlElement("waybill_no")]
        public string WaybillNo { get; set; }
    }
}
