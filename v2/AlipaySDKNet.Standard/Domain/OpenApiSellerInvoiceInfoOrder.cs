using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenApiSellerInvoiceInfoOrder Data Structure.
    /// </summary>
    [Serializable]
    public class OpenApiSellerInvoiceInfoOrder : AopObject
    {
        /// <summary>
        /// 开票人
        /// </summary>
        [XmlElement("drawer")]
        public string Drawer { get; set; }

        /// <summary>
        /// OU编码
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 可选, 发票抬头, 为空不填写时，从CIF或MIF取值
        /// </summary>
        [XmlElement("invoice_title")]
        public string InvoiceTitle { get; set; }

        /// <summary>
        /// 收款人
        /// </summary>
        [XmlElement("payee")]
        public string Payee { get; set; }

        /// <summary>
        /// 公司注册地址
        /// </summary>
        [XmlElement("registered_address")]
        public string RegisteredAddress { get; set; }

        /// <summary>
        /// 公司注册电话
        /// </summary>
        [XmlElement("registered_phone_no")]
        public string RegisteredPhoneNo { get; set; }

        /// <summary>
        /// 复核人
        /// </summary>
        [XmlElement("reviewer")]
        public string Reviewer { get; set; }

        /// <summary>
        /// 纳税人识别号
        /// </summary>
        [XmlElement("tax_no")]
        public string TaxNo { get; set; }

        /// <summary>
        /// 可选, 纳税人类型, 传枚举TaxPayerQualificationEnum的englishName 不传的话默认一般纳税人GENERAL_VAT_TAXPAYER
        /// </summary>
        [XmlElement("taxpayer_type")]
        public string TaxpayerType { get; set; }
    }
}
