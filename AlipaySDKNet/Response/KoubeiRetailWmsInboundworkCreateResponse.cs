using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiRetailWmsInboundworkCreateResponse.
    /// </summary>
    public class KoubeiRetailWmsInboundworkCreateResponse : AopResponse
    {
        /// <summary>
        /// 入库作业id
        /// </summary>
        [XmlElement("inbound_work_id")]
        public string InboundWorkId { get; set; }
    }
}
