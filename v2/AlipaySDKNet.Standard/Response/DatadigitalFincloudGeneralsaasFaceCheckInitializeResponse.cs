using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// DatadigitalFincloudGeneralsaasFaceCheckInitializeResponse.
    /// </summary>
    public class DatadigitalFincloudGeneralsaasFaceCheckInitializeResponse : AopResponse
    {
        /// <summary>
        /// 人脸检测流水ID，请保留方便排查问题
        /// </summary>
        [XmlElement("certify_id")]
        public string CertifyId { get; set; }

        /// <summary>
        /// 检测页面url，需要给到终端SDK
        /// </summary>
        [XmlElement("page_url")]
        public string PageUrl { get; set; }

        /// <summary>
        /// H5活体检测地址
        /// </summary>
        [XmlElement("web_url")]
        public string WebUrl { get; set; }
    }
}
