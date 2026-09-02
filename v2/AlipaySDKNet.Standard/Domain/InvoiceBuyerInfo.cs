using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InvoiceBuyerInfo Data Structure.
    /// </summary>
    [Serializable]
    public class InvoiceBuyerInfo : AopObject
    {
        /// <summary>
        /// 购方地址
        /// </summary>
        [XmlElement("buyer_address")]
        public string BuyerAddress { get; set; }

        /// <summary>
        /// 购方开户行
        /// </summary>
        [XmlElement("buyer_bank")]
        public string BuyerBank { get; set; }

        /// <summary>
        /// 购方银行账号
        /// </summary>
        [XmlElement("buyer_bank_account")]
        public string BuyerBankAccount { get; set; }

        /// <summary>
        /// 购方名称或发票抬头
        /// </summary>
        [XmlElement("buyer_name")]
        public string BuyerName { get; set; }

        /// <summary>
        /// 购方自然人证件号码
        /// </summary>
        [XmlElement("buyer_personal_id_number")]
        public string BuyerPersonalIdNumber { get; set; }

        /// <summary>
        /// 购方自然人证件类型
        /// </summary>
        [XmlElement("buyer_personal_id_type")]
        public string BuyerPersonalIdType { get; set; }

        /// <summary>
        /// 购方名称是否带个人,传 Y 或者 N，默认为 Y
        /// </summary>
        [XmlElement("buyer_personal_name_flag")]
        public string BuyerPersonalNameFlag { get; set; }

        /// <summary>
        /// 购方自然人国籍代码,中国156
        /// </summary>
        [XmlElement("buyer_personal_nationality_code")]
        public string BuyerPersonalNationalityCode { get; set; }

        /// <summary>
        /// 购方联系电话
        /// </summary>
        [XmlElement("buyer_phone")]
        public string BuyerPhone { get; set; }

        /// <summary>
        /// 购方税号
        /// </summary>
        [XmlElement("buyer_tax_no")]
        public string BuyerTaxNo { get; set; }
    }
}
