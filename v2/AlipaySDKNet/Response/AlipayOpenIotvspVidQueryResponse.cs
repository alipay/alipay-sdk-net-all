using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenIotvspVidQueryResponse.
    /// </summary>
    public class AlipayOpenIotvspVidQueryResponse : AopResponse
    {
        /// <summary>
        /// 刷脸的加密id
        /// </summary>
        [XmlElement("vid")]
        public string Vid { get; set; }
    }
}
