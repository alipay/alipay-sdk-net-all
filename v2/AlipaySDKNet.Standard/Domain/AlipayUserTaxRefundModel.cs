using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserTaxRefundModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserTaxRefundModel : AopObject
    {
        /// <summary>
        /// 资金记账本id
        /// </summary>
        [XmlElement("account_book_id")]
        public string AccountBookId { get; set; }

        /// <summary>
        /// 证件号
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 证件类型
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 退税申请单总金额
        /// </summary>
        [XmlElement("invoice_amount")]
        public string InvoiceAmount { get; set; }

        /// <summary>
        /// 二维码值
        /// </summary>
        [XmlElement("qr_code")]
        public string QrCode { get; set; }

        /// <summary>
        /// 总金额，单位为元，精确到小数点后两位，取值范围[0.1,100000000]。
        /// </summary>
        [XmlElement("refund_amount")]
        public string RefundAmount { get; set; }

        /// <summary>
        /// 退税申请单号
        /// </summary>
        [XmlElement("refund_biz_no")]
        public string RefundBizNo { get; set; }

        /// <summary>
        /// 退税人回乡证英文姓名
        /// </summary>
        [XmlElement("user_name")]
        public string UserName { get; set; }
    }
}
