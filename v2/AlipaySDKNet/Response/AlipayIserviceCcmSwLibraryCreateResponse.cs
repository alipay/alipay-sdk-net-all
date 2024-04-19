using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayIserviceCcmSwLibraryCreateResponse.
    /// </summary>
    public class AlipayIserviceCcmSwLibraryCreateResponse : AopResponse
    {
        /// <summary>
        /// 知识库Id
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }
    }
}
