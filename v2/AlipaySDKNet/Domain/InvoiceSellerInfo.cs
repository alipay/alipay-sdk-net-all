using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InvoiceSellerInfo Data Structure.
    /// </summary>
    [Serializable]
    public class InvoiceSellerInfo : AopObject
    {
        /// <summary>
        /// 销方地址
        /// </summary>
        [XmlElement("seller_address")]
        public string SellerAddress { get; set; }

        /// <summary>
        /// 销方开户行
        /// </summary>
        [XmlElement("seller_bank")]
        public string SellerBank { get; set; }

        /// <summary>
        /// 销方银行账号
        /// </summary>
        [XmlElement("seller_bank_account")]
        public string SellerBankAccount { get; set; }

        /// <summary>
        /// 销方名称
        /// </summary>
        [XmlElement("seller_name")]
        public string SellerName { get; set; }

        /// <summary>
        /// 销方电话
        /// </summary>
        [XmlElement("seller_phone")]
        public string SellerPhone { get; set; }

        /// <summary>
        /// 销方税号
        /// </summary>
        [XmlElement("seller_tax_no")]
        public string SellerTaxNo { get; set; }
    }
}
