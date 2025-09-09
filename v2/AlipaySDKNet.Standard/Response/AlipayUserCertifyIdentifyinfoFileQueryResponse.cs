using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserCertifyIdentifyinfoFileQueryResponse.
    /// </summary>
    public class AlipayUserCertifyIdentifyinfoFileQueryResponse : AopResponse
    {
        /// <summary>
        /// 文件的base64
        /// </summary>
        [XmlElement("file")]
        public string File { get; set; }
    }
}
