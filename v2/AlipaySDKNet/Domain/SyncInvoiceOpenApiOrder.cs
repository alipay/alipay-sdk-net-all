using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SyncInvoiceOpenApiOrder Data Structure.
    /// </summary>
    [Serializable]
    public class SyncInvoiceOpenApiOrder : AopObject
    {
        /// <summary>
        /// 上车时间，格式yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("boarding_time")]
        public string BoardingTime { get; set; }

        /// <summary>
        /// 购方地址电话
        /// </summary>
        [XmlElement("buyer_address_tel")]
        public string BuyerAddressTel { get; set; }

        /// <summary>
        /// 购方银行信息
        /// </summary>
        [XmlElement("buyer_bank_info")]
        public string BuyerBankInfo { get; set; }

        /// <summary>
        /// 购方公司名称
        /// </summary>
        [XmlElement("buyer_company_name")]
        public string BuyerCompanyName { get; set; }

        /// <summary>
        /// 购方ou
        /// </summary>
        [XmlElement("buyer_ou_code")]
        public string BuyerOuCode { get; set; }

        /// <summary>
        /// 购方税号
        /// </summary>
        [XmlElement("buyer_tax_no")]
        public string BuyerTaxNo { get; set; }

        /// <summary>
        /// 认证状态，使用调用方的枚举值
        /// </summary>
        [XmlElement("certify_state")]
        public string CertifyState { get; set; }

        /// <summary>
        /// 校验码
        /// </summary>
        [XmlElement("check_code")]
        public string CheckCode { get; set; }

        /// <summary>
        /// 验真状态，使用调用方的状态枚举
        /// </summary>
        [XmlElement("check_state")]
        public string CheckState { get; set; }

        /// <summary>
        /// 城市
        /// </summary>
        [XmlElement("city")]
        public string City { get; set; }

        /// <summary>
        /// 币种
        /// </summary>
        [XmlElement("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 乘车日期,格式yyyyMMdd
        /// </summary>
        [XmlElement("drive_date")]
        public string DriveDate { get; set; }

        /// <summary>
        /// 终点站
        /// </summary>
        [XmlElement("end_station")]
        public string EndStation { get; set; }

        /// <summary>
        /// 文件名
        /// </summary>
        [XmlElement("file_name")]
        public string FileName { get; set; }

        /// <summary>
        /// 附件url
        /// </summary>
        [XmlElement("file_url")]
        public string FileUrl { get; set; }

        /// <summary>
        /// 燃油附件费
        /// </summary>
        [XmlElement("fuel_surcharge")]
        public string FuelSurcharge { get; set; }

        /// <summary>
        /// 增值税发票为含税金额,其他票种的价格、合计金额等可通过此字段传入
        /// </summary>
        [XmlElement("invoice_amt")]
        public string InvoiceAmt { get; set; }

        /// <summary>
        /// 发票代码
        /// </summary>
        [XmlElement("invoice_code")]
        public string InvoiceCode { get; set; }

        /// <summary>
        /// 开票日期,格式:yyyyMMdd
        /// </summary>
        [XmlElement("invoice_date")]
        public string InvoiceDate { get; set; }

        /// <summary>
        /// 外部发票id
        /// </summary>
        [XmlElement("invoice_id")]
        public string InvoiceId { get; set; }

        /// <summary>
        /// 发票介质
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
        [XmlElement("invoice_note")]
        public string InvoiceNote { get; set; }

        /// <summary>
        /// 报销信息
        /// </summary>
        [XmlArray("invoice_reimburse_info_order_list")]
        [XmlArrayItem("invoice_reimburse_info_open_api_order")]
        public List<InvoiceReimburseInfoOpenApiOrder> InvoiceReimburseInfoOrderList { get; set; }

        /// <summary>
        /// 发票类型，使用调用平台自己的发票类型枚举
        /// </summary>
        [XmlElement("invoice_type")]
        public string InvoiceType { get; set; }

        /// <summary>
        /// 下车时间,格式:yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("off_time")]
        public string OffTime { get; set; }

        /// <summary>
        /// 平台code
        /// </summary>
        [XmlElement("platform_code")]
        public string PlatformCode { get; set; }

        /// <summary>
        /// 报销状态,使用调用方的枚举
        /// </summary>
        [XmlElement("reimburse_state")]
        public string ReimburseState { get; set; }

        /// <summary>
        /// 座次
        /// </summary>
        [XmlElement("seat")]
        public string Seat { get; set; }

        /// <summary>
        /// 销方地址电话
        /// </summary>
        [XmlElement("seller_address_tel")]
        public string SellerAddressTel { get; set; }

        /// <summary>
        /// 销方银行信息
        /// </summary>
        [XmlElement("seller_bank_info")]
        public string SellerBankInfo { get; set; }

        /// <summary>
        /// 销方公司名称
        /// </summary>
        [XmlElement("seller_company_name")]
        public string SellerCompanyName { get; set; }

        /// <summary>
        /// 销方税号
        /// </summary>
        [XmlElement("seller_tax_no")]
        public string SellerTaxNo { get; set; }

        /// <summary>
        /// 出发站
        /// </summary>
        [XmlElement("start_station")]
        public string StartStation { get; set; }

        /// <summary>
        /// 发票行
        /// </summary>
        [XmlArray("sync_invoice_line_order_list")]
        [XmlArrayItem("sync_invoice_line_open_api_order")]
        public List<SyncInvoiceLineOpenApiOrder> SyncInvoiceLineOrderList { get; set; }

        /// <summary>
        /// 税额
        /// </summary>
        [XmlElement("tax_amt")]
        public string TaxAmt { get; set; }

        /// <summary>
        /// 不含税金额
        /// </summary>
        [XmlElement("tax_exclusive_amt")]
        public string TaxExclusiveAmt { get; set; }
    }
}
