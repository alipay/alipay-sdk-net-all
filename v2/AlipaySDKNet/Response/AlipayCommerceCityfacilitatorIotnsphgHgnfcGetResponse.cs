using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceCityfacilitatorIotnsphgHgnfcGetResponse.
    /// </summary>
    public class AlipayCommerceCityfacilitatorIotnsphgHgnfcGetResponse : AopResponse
    {
        /// <summary>
        /// 业务内容
        /// </summary>
        [XmlElement("data")]
        public string Data { get; set; }
    }
}
