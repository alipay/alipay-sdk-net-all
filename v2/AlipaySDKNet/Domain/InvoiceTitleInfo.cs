using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InvoiceTitleInfo Data Structure.
    /// </summary>
    [Serializable]
    public class InvoiceTitleInfo : AopObject
    {
        /// <summary>
        /// 是否接受电子票 true:是，false:否
        /// </summary>
        [XmlElement("accept_electronic")]
        public bool AcceptElectronic { get; set; }

        /// <summary>
        /// 注册地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 银行账户
        /// </summary>
        [XmlElement("bank_account")]
        public string BankAccount { get; set; }

        /// <summary>
        /// 开户行
        /// </summary>
        [XmlElement("bank_name")]
        public string BankName { get; set; }

        /// <summary>
        /// 发票抬头类型
        /// </summary>
        [XmlElement("ip_role_type")]
        public string IpRoleType { get; set; }

        /// <summary>
        /// 当前操作人 个人的2088号
        /// </summary>
        [XmlElement("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 纳税人识别号
        /// </summary>
        [XmlElement("tax_no")]
        public string TaxNo { get; set; }

        /// <summary>
        /// 纳税人资格开始时间 （格式：时间戳） 一般纳税人必须填写，yyyyMMdd 小规模纳税人无需填写 例如20211220
        /// </summary>
        [XmlElement("tax_payer_quali_valid")]
        public string TaxPayerQualiValid { get; set; }

        /// <summary>
        /// 纳税人资格种类
        /// </summary>
        [XmlElement("tax_payer_qualification")]
        public string TaxPayerQualification { get; set; }

        /// <summary>
        /// 注册电话
        /// </summary>
        [XmlElement("telephone")]
        public string Telephone { get; set; }

        /// <summary>
        /// 发票抬头
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
