using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IdentityInfo Data Structure.
    /// </summary>
    [Serializable]
    public class IdentityInfo : AopObject
    {
        /// <summary>
        /// 用户信息，longid或者openId
        /// </summary>
        [XmlElement("identity")]
        public string Identity { get; set; }

        /// <summary>
        /// 用户姓名。当identity_type是ALIPAY_LOGON_ID时，需要传
        /// </summary>
        [XmlElement("identity_name")]
        public string IdentityName { get; set; }

        /// <summary>
        /// 用户身份类型；当type为ALIPAY_LOGON_ID时，需要传入identity_name；当type是ALIPAY_OPEN_ID时，不需要传identity_name
        /// </summary>
        [XmlElement("identity_type")]
        public string IdentityType { get; set; }
    }
}
