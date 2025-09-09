using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// DatadigitalFincloudGeneralsaasBankcardCheckResponse.
    /// </summary>
    public class DatadigitalFincloudGeneralsaasBankcardCheckResponse : AopResponse
    {
        /// <summary>
        /// 认证单据号，用于认证问题排查
        /// </summary>
        [XmlElement("certify_id")]
        public string CertifyId { get; set; }

        /// <summary>
        /// 核验详情
        /// </summary>
        [XmlElement("detail")]
        public string Detail { get; set; }

        /// <summary>
        /// 是否核验通过
        /// </summary>
        [XmlElement("match")]
        public string Match { get; set; }
    }
}
