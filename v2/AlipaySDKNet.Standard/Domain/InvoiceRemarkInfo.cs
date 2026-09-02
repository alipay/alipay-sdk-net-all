using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InvoiceRemarkInfo Data Structure.
    /// </summary>
    [Serializable]
    public class InvoiceRemarkInfo : AopObject
    {
        /// <summary>
        /// 发票备注
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 是否显示购方地址和电话，Y 显示，N 不显示。 默认为 N
        /// </summary>
        [XmlElement("show_buyer_address_phone")]
        public string ShowBuyerAddressPhone { get; set; }

        /// <summary>
        /// 是否显示购方银行账号,Y 显示，N 不显示。 默认为 N
        /// </summary>
        [XmlElement("show_buyer_bank_account")]
        public string ShowBuyerBankAccount { get; set; }

        /// <summary>
        /// 是否显示销方地址和电话。Y 显示，N 不显示。 默认为 N
        /// </summary>
        [XmlElement("show_seller_address_phone")]
        public string ShowSellerAddressPhone { get; set; }

        /// <summary>
        /// 是否显示销方银行账号，Y 显示，N 不显示。 默认为 N
        /// </summary>
        [XmlElement("show_seller_bank_account")]
        public string ShowSellerBankAccount { get; set; }
    }
}
