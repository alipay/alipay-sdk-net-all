using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayIserviceCcmSwItemDeleteResponse.
    /// </summary>
    public class AlipayIserviceCcmSwItemDeleteResponse : AopResponse
    {
        /// <summary>
        /// 外部透传批量操作id,用于问题排查
        /// </summary>
        [XmlElement("syn_id")]
        public string SynId { get; set; }
    }
}
