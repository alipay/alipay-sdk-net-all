using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppEbppInstnoticeCreateormodifyResponse.
    /// </summary>
    public class AlipayEbppEbppInstnoticeCreateormodifyResponse : AopResponse
    {
        /// <summary>
        /// 流程标识，用来查询流程的执行状态。
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }
    }
}
