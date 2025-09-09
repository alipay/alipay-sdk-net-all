using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommercePetinsureQueryResponse.
    /// </summary>
    public class AlipayCommercePetinsureQueryResponse : AopResponse
    {
        /// <summary>
        /// 投保状态
        /// </summary>
        [XmlElement("insure_status")]
        public string InsureStatus { get; set; }
    }
}
