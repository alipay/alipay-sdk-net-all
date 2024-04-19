using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenIotvspFaceimgstateQueryResponse.
    /// </summary>
    public class AlipayOpenIotvspFaceimgstateQueryResponse : AopResponse
    {
        /// <summary>
        /// true-已上传 false-未上传
        /// </summary>
        [XmlElement("upload")]
        public bool Upload { get; set; }
    }
}
