using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SecondaryPartnerInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SecondaryPartnerInfo : AopObject
    {
        /// <summary>
        /// 参与方的唯一标识
        /// </summary>
        [XmlElement("identity")]
        public string Identity { get; set; }

        /// <summary>
        /// 参与方的标识类型，目前支持如下类型：  1、ALIPAY_USER_ID 支付宝的会员ID  2、ALIPAY_LOGON_ID：支付宝登录号，支持邮箱和手机号格式  3、ALIPAY_OPEN_ID：支付宝openid
        /// </summary>
        [XmlElement("identity_type")]
        public string IdentityType { get; set; }

        /// <summary>
        /// 参与方真实姓名，如果非空，将校验支付宝账号姓名一致性。当identity_type=ALIPAY_LOGON_ID时，本字段必填。
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
