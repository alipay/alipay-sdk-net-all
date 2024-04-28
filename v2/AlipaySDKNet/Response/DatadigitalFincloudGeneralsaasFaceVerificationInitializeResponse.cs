using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// DatadigitalFincloudGeneralsaasFaceVerificationInitializeResponse.
    /// </summary>
    public class DatadigitalFincloudGeneralsaasFaceVerificationInitializeResponse : AopResponse
    {
        /// <summary>
        /// 认证单据号，请保留以便排查问题。
        /// </summary>
        [XmlElement("certify_id")]
        public string CertifyId { get; set; }

        /// <summary>
        /// 人脸核身url
        /// </summary>
        [XmlElement("page_url")]
        public string PageUrl { get; set; }

        /// <summary>
        /// H5人脸核身地址
        /// </summary>
        [XmlElement("web_url")]
        public string WebUrl { get; set; }
    }
}
