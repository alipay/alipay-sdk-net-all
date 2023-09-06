using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EmployeeTitleInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class EmployeeTitleInfoDTO : AopObject
    {
        /// <summary>
        /// 地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 抬头名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 开户行帐号
        /// </summary>
        [XmlElement("open_bank_account")]
        public string OpenBankAccount { get; set; }

        /// <summary>
        /// 开户行名称
        /// </summary>
        [XmlElement("open_bank_name")]
        public string OpenBankName { get; set; }

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
        /// 抬头类型
        /// </summary>
        [XmlElement("title_tag")]
        public string TitleTag { get; set; }
    }
}
