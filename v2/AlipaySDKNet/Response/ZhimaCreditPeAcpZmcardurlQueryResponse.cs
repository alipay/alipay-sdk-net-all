using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditPeAcpZmcardurlQueryResponse.
    /// </summary>
    public class ZhimaCreditPeAcpZmcardurlQueryResponse : AopResponse
    {
        /// <summary>
        /// 芝麻证跳转url，用于分享给其他用户扫描访问
        /// </summary>
        [XmlElement("skip_url")]
        public string SkipUrl { get; set; }
    }
}
