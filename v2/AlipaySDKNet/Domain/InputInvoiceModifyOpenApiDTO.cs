using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InputInvoiceModifyOpenApiDTO Data Structure.
    /// </summary>
    [Serializable]
    public class InputInvoiceModifyOpenApiDTO : AopObject
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
        /// 有效税额，币种单位使用currency字段
        /// </summary>
        [XmlElement("effective_tax_amount")]
        public string EffectiveTaxAmount { get; set; }

        /// <summary>
        /// 不含税金额
        /// </summary>
        [XmlElement("excluding_tax_amount")]
        public string ExcludingTaxAmount { get; set; }

        /// <summary>
        /// 发票代码
        /// </summary>
        [XmlElement("invoice_code")]
        public string InvoiceCode { get; set; }

        /// <summary>
        /// 发票id，通过发票登记接口录入发票后获取
        /// </summary>
        [XmlElement("invoice_id")]
        public long InvoiceId { get; set; }

        /// <summary>
        /// 发票介质类型
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
        /// 二维码标识
        /// </summary>
        [XmlElement("qr_code_flag")]
        public string QrCodeFlag { get; set; }

        /// <summary>
        /// 关联单据号
        /// </summary>
        [XmlElement("related_order")]
        public string RelatedOrder { get; set; }

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
        /// 发票税额，币种单位使用currency字段
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
