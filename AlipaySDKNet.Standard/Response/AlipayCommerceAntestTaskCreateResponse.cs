using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceAntestTaskCreateResponse.
    /// </summary>
    public class AlipayCommerceAntestTaskCreateResponse : AopResponse
    {
        /// <summary>
        /// 任务id
        /// </summary>
        [XmlElement("batch_id")]
        public long BatchId { get; set; }
    }
}
