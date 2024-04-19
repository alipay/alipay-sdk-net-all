using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TransParticipant Data Structure.
    /// </summary>
    [Serializable]
    public class TransParticipant : AopObject
    {
        /// <summary>
        /// 银行卡信息
        /// </summary>
        [XmlElement("bankcard_ext_info")]
        public BankCardExtInfoDTO BankcardExtInfo { get; set; }

        /// <summary>
        /// 身份唯一标识。
        /// </summary>
        [XmlElement("identity")]
        public string Identity { get; set; }

        /// <summary>
        /// 支付宝余额户: ALIPAY_ACCOUNT； 银行卡：BANK_CARD； 资金专户：BOOK；
        /// </summary>
        [XmlElement("identity_type")]
        public string IdentityType { get; set; }

        /// <summary>
        /// 用户真实姓名，支付宝的用户姓名或银行账户名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
