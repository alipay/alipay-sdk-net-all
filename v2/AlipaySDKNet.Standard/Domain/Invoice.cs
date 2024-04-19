using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// Invoice Data Structure.
    /// </summary>
    [Serializable]
    public class Invoice : AopObject
    {
        /// <summary>
        /// 邮箱地址
        /// </summary>
        [XmlElement("email")]
        public string Email { get; set; }

        /// <summary>
        /// 发票内容，配送服务费
        /// </summary>
        [XmlElement("invoice_content")]
        public string InvoiceContent { get; set; }

        /// <summary>
        /// 发票金额
        /// </summary>
        [XmlElement("invoice_fee")]
        public string InvoiceFee { get; set; }

        /// <summary>
        /// 发票抬头，如支付宝（杭州）信息技术有限公司
        /// </summary>
        [XmlElement("invoice_title")]
        public string InvoiceTitle { get; set; }

        /// <summary>
        /// 发票类型，0：默认电子发票
        /// </summary>
        [XmlElement("invoice_type")]
        public long InvoiceType { get; set; }

        /// <summary>
        /// 手机号码
        /// </summary>
        [XmlElement("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// 收件人姓名
        /// </summary>
        [XmlElement("receiver")]
        public string Receiver { get; set; }

        /// <summary>
        /// 税号
        /// </summary>
        [XmlElement("tax_number")]
        public string TaxNumber { get; set; }

        /// <summary>
        /// 抬头类型，0：企业单位，1：个人/非企业
        /// </summary>
        [XmlElement("title_type")]
        public long TitleType { get; set; }
    }
}
