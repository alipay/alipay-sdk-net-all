using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenIotmbsFacedbDeleteResponse.
    /// </summary>
    public class AlipayOpenIotmbsFacedbDeleteResponse : AopResponse
    {
        /// <summary>
        /// 成功true失败false
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
