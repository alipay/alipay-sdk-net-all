using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FreightFlowOppositeAccountInfo Data Structure.
    /// </summary>
    [Serializable]
    public class FreightFlowOppositeAccountInfo : AopObject
    {
        /// <summary>
        /// 证件号
        /// </summary>
        [XmlElement("account_cert_no")]
        public string AccountCertNo { get; set; }

        /// <summary>
        /// 账户身份类型
        /// </summary>
        [XmlElement("account_cert_type")]
        public string AccountCertType { get; set; }

        /// <summary>
        /// 参与者类型(外部银行卡 必填)
        /// </summary>
        [XmlElement("account_customer_type")]
        public string AccountCustomerType { get; set; }

        /// <summary>
        /// 参与者联联行号(外部银行卡 必填)
        /// </summary>
        [XmlElement("account_inst_code")]
        public string AccountInstCode { get; set; }

        /// <summary>
        /// 参与者编号(外部银行卡 必填) ●网商结算户：卡号 ●子户：子户卡号 ●外部银行卡：银行卡号
        /// </summary>
        [XmlElement("account_no")]
        public string AccountNo { get; set; }

        /// <summary>
        /// 账户类型
        /// </summary>
        [XmlElement("account_type")]
        public string AccountType { get; set; }
    }
}
