using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// DatadigitalFincloudGeneralsaasTwometaCheckResponse.
    /// </summary>
    public class DatadigitalFincloudGeneralsaasTwometaCheckResponse : AopResponse
    {
        /// <summary>
        /// 认证单据号，用于认证问题排查
        /// </summary>
        [XmlElement("certify_id")]
        public string CertifyId { get; set; }

        /// <summary>
        /// 二要素是否匹配成功
        /// </summary>
        [XmlElement("match")]
        public string Match { get; set; }
    }
}
