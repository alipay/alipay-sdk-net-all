using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpCreditlinkAuthCreateResponse.
    /// </summary>
    public class ZhimaCreditEpCreditlinkAuthCreateResponse : AopResponse
    {
        /// <summary>
        /// 授权有效时间
        /// </summary>
        [XmlElement("expire_time")]
        public string ExpireTime { get; set; }
    }
}
