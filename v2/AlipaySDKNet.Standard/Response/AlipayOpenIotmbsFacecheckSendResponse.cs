using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenIotmbsFacecheckSendResponse.
    /// </summary>
    public class AlipayOpenIotmbsFacecheckSendResponse : AopResponse
    {
        /// <summary>
        /// 成功true失败false
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
