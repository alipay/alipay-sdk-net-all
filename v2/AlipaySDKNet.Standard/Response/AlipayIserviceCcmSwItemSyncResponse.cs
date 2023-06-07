using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayIserviceCcmSwItemSyncResponse.
    /// </summary>
    public class AlipayIserviceCcmSwItemSyncResponse : AopResponse
    {
        /// <summary>
        /// 返回的外部批次id
        /// </summary>
        [XmlElement("syn_id")]
        public string SynId { get; set; }
    }
}
