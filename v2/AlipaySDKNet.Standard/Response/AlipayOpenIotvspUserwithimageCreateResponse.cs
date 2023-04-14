using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenIotvspUserwithimageCreateResponse.
    /// </summary>
    public class AlipayOpenIotvspUserwithimageCreateResponse : AopResponse
    {
        /// <summary>
        /// 用户唯一标识
        /// </summary>
        [XmlElement("vid")]
        public string Vid { get; set; }
    }
}
