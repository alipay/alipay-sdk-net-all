using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceIsportalLoginencryptjwtQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceIsportalLoginencryptjwtQueryModel : AopObject
    {
        /// <summary>
        /// 过期秒数
        /// </summary>
        [XmlElement("expiry_time")]
        public long ExpiryTime { get; set; }

        /// <summary>
        /// 令牌
        /// </summary>
        [XmlElement("login_token")]
        public string LoginToken { get; set; }
    }
}
