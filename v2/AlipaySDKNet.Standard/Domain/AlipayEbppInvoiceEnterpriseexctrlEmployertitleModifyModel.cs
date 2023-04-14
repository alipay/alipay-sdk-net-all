using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppInvoiceEnterpriseexctrlEmployertitleModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppInvoiceEnterpriseexctrlEmployertitleModifyModel : AopObject
    {
        /// <summary>
        /// 共同账户id，与enterprise_id两者必填其一
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 详细地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 授权签约协议号
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 开户行账号
        /// </summary>
        [XmlElement("bank_account")]
        public string BankAccount { get; set; }

        /// <summary>
        /// 开户行
        /// </summary>
        [XmlElement("bank_name")]
        public string BankName { get; set; }

        /// <summary>
        /// 企业id，与account_id两者必填其一
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 税号
        /// </summary>
        [XmlElement("tax_register_no")]
        public string TaxRegisterNo { get; set; }

        /// <summary>
        /// 电话
        /// </summary>
        [XmlElement("telephone")]
        public string Telephone { get; set; }

        /// <summary>
        /// 抬头ID
        /// </summary>
        [XmlElement("title_id")]
        public string TitleId { get; set; }

        /// <summary>
        /// 企业抬头名称
        /// </summary>
        [XmlElement("title_name")]
        public string TitleName { get; set; }
    }
}
