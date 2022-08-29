using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ConsultParticipant Data Structure.
    /// </summary>
    [Serializable]
    public class ConsultParticipant : AopObject
    {
        /// <summary>
        /// 参与方的唯一标识
        /// </summary>
        [XmlElement("identity")]
        public string Identity { get; set; }

        /// <summary>
        /// 参与方的标识类型，有限枚举： 1.ALIPAY_USER_ID：支付宝的会员ID 2.ALIPAY_LOGON_ID：支付宝登录号，支持邮箱和手机号格式
        /// </summary>
        [XmlElement("identity_type")]
        public string IdentityType { get; set; }
    }
}
