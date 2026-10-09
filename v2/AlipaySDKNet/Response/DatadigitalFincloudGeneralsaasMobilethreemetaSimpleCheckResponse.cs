using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// DatadigitalFincloudGeneralsaasMobilethreemetaSimpleCheckResponse.
    /// </summary>
    public class DatadigitalFincloudGeneralsaasMobilethreemetaSimpleCheckResponse : AopResponse
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
        /// 手机号对应的运营商名称
        /// </summary>
        [XmlElement("isp")]
        public string Isp { get; set; }

        /// <summary>
        /// 是否核验通过
        /// </summary>
        [XmlElement("match")]
        public string Match { get; set; }
    }
}
