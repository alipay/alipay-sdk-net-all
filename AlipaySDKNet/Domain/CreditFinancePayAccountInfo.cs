using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CreditFinancePayAccountInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CreditFinancePayAccountInfo : AopObject
    {
        /// <summary>
        /// 账号的扩展信息，String格式的json字符串
        /// </summary>
        [XmlElement("account_ext")]
        public string AccountExt { get; set; }

        /// <summary>
        /// 支付的账号标识
        /// </summary>
        [XmlElement("identity")]
        public string Identity { get; set; }

        /// <summary>
        /// 支付宝唯一标识的类型 ENTRUST_ACCOUNT USER_ID
        /// </summary>
        [XmlElement("identity_type")]
        public string IdentityType { get; set; }
    }
}
