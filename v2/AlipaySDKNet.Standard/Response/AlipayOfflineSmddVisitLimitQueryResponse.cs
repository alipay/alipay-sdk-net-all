using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOfflineSmddVisitLimitQueryResponse.
    /// </summary>
    public class AlipayOfflineSmddVisitLimitQueryResponse : AopResponse
    {
        /// <summary>
        /// true:禁止 false:不禁止
        /// </summary>
        [XmlElement("limit")]
        public bool Limit { get; set; }

        /// <summary>
        /// 访问受限文案
        /// </summary>
        [XmlElement("limit_msg")]
        public string LimitMsg { get; set; }

        /// <summary>
        /// 访问受限类型，INTERCEPT:拦截式，阻止用户继续访问
        /// </summary>
        [XmlElement("limit_type")]
        public string LimitType { get; set; }
    }
}
