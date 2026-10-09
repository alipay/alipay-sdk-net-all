using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsSceneInsserviceprodSerprivacyApplyResponse.
    /// </summary>
    public class AlipayInsSceneInsserviceprodSerprivacyApplyResponse : AopResponse
    {
        /// <summary>
        /// 隐私号
        /// </summary>
        [XmlElement("bind_phone")]
        public string BindPhone { get; set; }

        /// <summary>
        /// 隐私号过期时间
        /// </summary>
        [XmlElement("expired_time")]
        public string ExpiredTime { get; set; }

        /// <summary>
        /// axn分机号，仅axn分机号模式有数值
        /// </summary>
        [XmlElement("extension_no")]
        public string ExtensionNo { get; set; }
    }
}
