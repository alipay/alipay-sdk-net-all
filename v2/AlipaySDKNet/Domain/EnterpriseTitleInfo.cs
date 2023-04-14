using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EnterpriseTitleInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EnterpriseTitleInfo : AopObject
    {
        /// <summary>
        /// 详细地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 开户行账号
        /// </summary>
        [XmlElement("bank_account")]
        public string BankAccount { get; set; }

        /// <summary>
        /// 开户行地址
        /// </summary>
        [XmlElement("bank_name")]
        public string BankName { get; set; }

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
        /// 抬头与企业关系表主键
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
