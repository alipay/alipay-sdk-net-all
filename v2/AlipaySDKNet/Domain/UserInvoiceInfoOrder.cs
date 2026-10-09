using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// UserInvoiceInfoOrder Data Structure.
    /// </summary>
    [Serializable]
    public class UserInvoiceInfoOrder : AopObject
    {
        /// <summary>
        /// 购方公司
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 购方公司注册银行卡号
        /// </summary>
        [XmlElement("bank_account")]
        public string BankAccount { get; set; }

        /// <summary>
        /// 购方公司的注册银行名称
        /// </summary>
        [XmlElement("bank_name")]
        public string BankName { get; set; }

        /// <summary>
        /// 购方公司的抬头
        /// </summary>
        [XmlElement("company_name")]
        public string CompanyName { get; set; }

        /// <summary>
        /// 商户PID,传入购方商户的pid，无pid开票时传2088999999999999
        /// </summary>
        [XmlElement("ip_role_id")]
        public string IpRoleId { get; set; }

        /// <summary>
        /// 收件邮寄地址信息
        /// </summary>
        [XmlElement("recipient_info")]
        public RecipientInfoOrder RecipientInfo { get; set; }

        /// <summary>
        /// 购方公司的税号
        /// </summary>
        [XmlElement("tax_no")]
        public string TaxNo { get; set; }

        /// <summary>
        /// 购方公司电话
        /// </summary>
        [XmlElement("telephone")]
        public string Telephone { get; set; }
    }
}
