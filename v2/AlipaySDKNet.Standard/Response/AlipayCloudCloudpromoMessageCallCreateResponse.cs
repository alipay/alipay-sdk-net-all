using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudpromoMessageCallCreateResponse.
    /// </summary>
    public class AlipayCloudCloudpromoMessageCallCreateResponse : AopResponse
    {
        /// <summary>
        /// 智能触达时记录ID，用于查询触达结果
        /// </summary>
        [XmlElement("record_id")]
        public string RecordId { get; set; }
    }
}
