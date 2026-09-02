using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// XingheLendassistCarfinauctionApplyloanNotifyResponse.
    /// </summary>
    public class XingheLendassistCarfinauctionApplyloanNotifyResponse : AopResponse
    {
        /// <summary>
        /// 预计放款时间
        /// </summary>
        [XmlElement("disburse_time")]
        public string DisburseTime { get; set; }
    }
}
