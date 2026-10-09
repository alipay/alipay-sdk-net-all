using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEducateStudentverifyPhotoSyncResponse.
    /// </summary>
    public class AlipayCommerceEducateStudentverifyPhotoSyncResponse : AopResponse
    {
        /// <summary>
        /// 请求响应结果数据
        /// </summary>
        [XmlElement("data")]
        public string Data { get; set; }
    }
}
