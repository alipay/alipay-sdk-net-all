using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayIserviceCcmLcsLcsserversSaveResponse.
    /// </summary>
    public class AlipayIserviceCcmLcsLcsserversSaveResponse : AopResponse
    {
        /// <summary>
        /// 操作返回结果
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
