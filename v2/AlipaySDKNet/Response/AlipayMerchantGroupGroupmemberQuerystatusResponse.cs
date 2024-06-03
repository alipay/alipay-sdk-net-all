using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantGroupGroupmemberQuerystatusResponse.
    /// </summary>
    public class AlipayMerchantGroupGroupmemberQuerystatusResponse : AopResponse
    {
        /// <summary>
        /// 是否入群的标识
        /// </summary>
        [XmlElement("joined")]
        public bool Joined { get; set; }
    }
}
