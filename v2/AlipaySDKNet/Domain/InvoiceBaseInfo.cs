using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InvoiceBaseInfo Data Structure.
    /// </summary>
    [Serializable]
    public class InvoiceBaseInfo : AopObject
    {
        /// <summary>
        /// 发票校验码（返回后6位）
        /// </summary>
        [XmlElement("check_code")]
        public string CheckCode { get; set; }

        /// <summary>
        /// 价税合计金额（单位/元）
        /// </summary>
        [XmlElement("invoice_amt")]
        public string InvoiceAmt { get; set; }

        /// <summary>
        /// 发票类型： ELEC_ADD_TAX_SIMPLE : 增值税普票-电子版 PAPER_ADD_TAX_SIMPLE：增值税普票-纸质版 PAPER_QUOTA：手撕定额发票
        /// </summary>
        [XmlElement("invoice_category")]
        public string InvoiceCategory { get; set; }

        /// <summary>
        /// 发票代码，全电票没有
        /// </summary>
        [XmlElement("invoice_code")]
        public string InvoiceCode { get; set; }

        /// <summary>
        /// 开票日期（yyyyMMdd）
        /// </summary>
        [XmlElement("invoice_date")]
        public string InvoiceDate { get; set; }

        /// <summary>
        /// 支付宝返回的已提交的发票唯一ID
        /// </summary>
        [XmlElement("invoice_id")]
        public string InvoiceId { get; set; }

        /// <summary>
        /// 发票影像文件存储地址
        /// </summary>
        [XmlElement("invoice_image")]
        public string InvoiceImage { get; set; }

        /// <summary>
        /// 发票号码（全电票的20位）
        /// </summary>
        [XmlElement("invoice_no")]
        public string InvoiceNo { get; set; }

        /// <summary>
        /// 发票外部索引号
        /// </summary>
        [XmlElement("invoice_out_no")]
        public string InvoiceOutNo { get; set; }

        /// <summary>
        /// 发票类型
        /// </summary>
        [XmlElement("invoice_type")]
        public string InvoiceType { get; set; }

        /// <summary>
        /// 开票主体，销方
        /// </summary>
        [XmlElement("seller_company_name")]
        public string SellerCompanyName { get; set; }

        /// <summary>
        /// 税额
        /// </summary>
        [XmlElement("tax_amt")]
        public string TaxAmt { get; set; }

        /// <summary>
        /// 发票税局来源: FULL_ELECTRONIC：全电发票, TAX_CONTROLLED：税控发票
        /// </summary>
        [XmlElement("tax_bureau_source")]
        public string TaxBureauSource { get; set; }
    }
}
