using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CompleteVoucherInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CompleteVoucherInfo : AopObject
    {
        /// <summary>
        /// 防伪码
        /// </summary>
        [XmlElement("anti_fake_code")]
        public string AntiFakeCode { get; set; }

        /// <summary>
        /// 校验码
        /// </summary>
        [XmlElement("check_sum")]
        public string CheckSum { get; set; }

        /// <summary>
        /// 开票机器码
        /// </summary>
        [XmlElement("device_no")]
        public string DeviceNo { get; set; }

        /// <summary>
        /// 板式文件下载地址
        /// </summary>
        [XmlElement("file_download_url")]
        public string FileDownloadUrl { get; set; }

        /// <summary>
        /// 板式文件的类型
        /// </summary>
        [XmlElement("file_type")]
        public string FileType { get; set; }

        /// <summary>
        /// 发票金额
        /// </summary>
        [XmlElement("invoice_amount")]
        public long InvoiceAmount { get; set; }

        /// <summary>
        /// 发票代码
        /// </summary>
        [XmlElement("invoice_code")]
        public string InvoiceCode { get; set; }

        /// <summary>
        /// 汇总发票详细信息(目前该字段为空)
        /// </summary>
        [XmlArray("invoice_content_list")]
        [XmlArrayItem("invoice_content_info")]
        public List<InvoiceContentInfo> InvoiceContentList { get; set; }

        /// <summary>
        /// 发票日期
        /// </summary>
        [XmlElement("invoice_date")]
        public string InvoiceDate { get; set; }

        /// <summary>
        /// 发票类型 0：增值税普通电子发票 1：增值税普通发票 2：增值税专用发票 3：增值税专用电子发票 4：财政电子发票
        /// </summary>
        [XmlElement("invoice_kind")]
        public long InvoiceKind { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [XmlElement("invoice_memo")]
        public string InvoiceMemo { get; set; }

        /// <summary>
        /// 发票号码
        /// </summary>
        [XmlElement("invoice_no")]
        public string InvoiceNo { get; set; }

        /// <summary>
        /// 发票来源，取值范围 SUMMARY_INVOICE_AUTO_OPEN 汇总开票系统自动开票，SUMMARY_INVOICE_MERCHANT_UPLOAD 汇总开票商户手动上传
        /// </summary>
        [XmlElement("invoice_source")]
        public string InvoiceSource { get; set; }

        /// <summary>
        /// 发票抬头
        /// </summary>
        [XmlElement("invoice_title")]
        public string InvoiceTitle { get; set; }

        /// <summary>
        /// 发票类型(红、蓝)
        /// </summary>
        [XmlElement("invoice_type")]
        public string InvoiceType { get; set; }

        /// <summary>
        /// 销售方地址
        /// </summary>
        [XmlElement("payee_address")]
        public string PayeeAddress { get; set; }

        /// <summary>
        /// 销售方银行账号
        /// </summary>
        [XmlElement("payee_bank_account")]
        public string PayeeBankAccount { get; set; }

        /// <summary>
        /// 销售方银行名称
        /// </summary>
        [XmlElement("payee_bank_name")]
        public string PayeeBankName { get; set; }

        /// <summary>
        /// 复核人
        /// </summary>
        [XmlElement("payee_checker")]
        public string PayeeChecker { get; set; }

        /// <summary>
        /// 销售方电话
        /// </summary>
        [XmlElement("payee_mobile")]
        public string PayeeMobile { get; set; }

        /// <summary>
        /// 销售方名称
        /// </summary>
        [XmlElement("payee_name")]
        public string PayeeName { get; set; }

        /// <summary>
        /// 开票人
        /// </summary>
        [XmlElement("payee_operator")]
        public string PayeeOperator { get; set; }

        /// <summary>
        /// 收款人
        /// </summary>
        [XmlElement("payee_receiver")]
        public string PayeeReceiver { get; set; }

        /// <summary>
        /// 销售方税号
        /// </summary>
        [XmlElement("payee_register_no")]
        public string PayeeRegisterNo { get; set; }

        /// <summary>
        /// 购买方地址
        /// </summary>
        [XmlElement("payer_address")]
        public string PayerAddress { get; set; }

        /// <summary>
        /// 购买方银行账号
        /// </summary>
        [XmlElement("payer_bank_account")]
        public string PayerBankAccount { get; set; }

        /// <summary>
        /// 购买方银行名称
        /// </summary>
        [XmlElement("payer_bank_name")]
        public string PayerBankName { get; set; }

        /// <summary>
        /// 购买方电话
        /// </summary>
        [XmlElement("payer_mobile")]
        public string PayerMobile { get; set; }

        /// <summary>
        /// 购买方名称
        /// </summary>
        [XmlElement("payer_name")]
        public string PayerName { get; set; }

        /// <summary>
        /// 购买方税号
        /// </summary>
        [XmlElement("payer_register_no")]
        public string PayerRegisterNo { get; set; }

        /// <summary>
        /// 不含税金额
        /// </summary>
        [XmlElement("sum_price")]
        public long SumPrice { get; set; }

        /// <summary>
        /// 合计税额
        /// </summary>
        [XmlElement("sum_tax")]
        public long SumTax { get; set; }
    }
}
