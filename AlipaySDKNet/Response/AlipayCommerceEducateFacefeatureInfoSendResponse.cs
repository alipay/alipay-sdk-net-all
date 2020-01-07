using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEducateFacefeatureInfoSendResponse.
    /// </summary>
    public class AlipayCommerceEducateFacefeatureInfoSendResponse : AopResponse
    {
        /// <summary>
        /// 返回更新失败的userId集合
        /// </summary>
        [XmlElement("error_uids")]
        public string ErrorUids { get; set; }
    }
}
