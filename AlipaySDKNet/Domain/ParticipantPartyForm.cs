using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ParticipantPartyForm Data Structure.
    /// </summary>
    [Serializable]
    public class ParticipantPartyForm : AopObject
    {
        /// <summary>
        /// 参与者的业务身份标识
        /// </summary>
        [XmlElement("identity")]
        public string Identity { get; set; }

        /// <summary>
        /// ALIPAY_OPEN_ID代表identity为支付宝开放用户ID；ALIPAY_LOGON_ID代表identity为支付宝用户登录号；
        /// </summary>
        [XmlElement("identity_type")]
        public string IdentityType { get; set; }

        /// <summary>
        /// 用户姓名，在identity_type为ALIPAY_LOGON_ID时必填
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
