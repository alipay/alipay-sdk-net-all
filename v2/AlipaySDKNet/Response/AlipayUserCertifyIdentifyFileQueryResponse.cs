using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserCertifyIdentifyFileQueryResponse.
    /// </summary>
    public class AlipayUserCertifyIdentifyFileQueryResponse : AopResponse
    {
        /// <summary>
        /// 文件的base64数据，一般情况是小于2M的
        /// </summary>
        [XmlElement("file")]
        public string File { get; set; }
    }
}
