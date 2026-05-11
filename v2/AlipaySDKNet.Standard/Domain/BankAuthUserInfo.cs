using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BankAuthUserInfo Data Structure.
    /// </summary>
    [Serializable]
    public class BankAuthUserInfo : AopObject
    {
        /// <summary>
        /// 授权用户的支付宝账号
        /// </summary>
        [XmlElement("alipay_account_no")]
        public string AlipayAccountNo { get; set; }

        /// <summary>
        /// 授权用户的支付宝昵称
        /// </summary>
        [XmlElement("alipay_nick_name")]
        public string AlipayNickName { get; set; }

        /// <summary>
        /// 授权用户的支付宝外标卡号
        /// </summary>
        [XmlElement("alipay_out_card_no")]
        public string AlipayOutCardNo { get; set; }

        /// <summary>
        /// 授权用户身份证号
        /// </summary>
        [XmlElement("user_cert_no")]
        public string UserCertNo { get; set; }

        /// <summary>
        /// 授权用户姓名
        /// </summary>
        [XmlElement("user_name")]
        public string UserName { get; set; }
    }
}
