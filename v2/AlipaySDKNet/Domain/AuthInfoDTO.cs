using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AuthInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class AuthInfoDTO : AopObject
    {
        /// <summary>
        /// 授权协议号
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 授权的支付宝账号，脱敏。
        /// </summary>
        [XmlElement("alipay_logon_id")]
        public string AlipayLogonId { get; set; }
    }
}
