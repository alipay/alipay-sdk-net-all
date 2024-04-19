using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantQipanCrowdwithturingtagQueryResponse.
    /// </summary>
    public class AlipayMerchantQipanCrowdwithturingtagQueryResponse : AopResponse
    {
        /// <summary>
        /// 人群规模
        /// </summary>
        [XmlElement("count_range")]
        public string CountRange { get; set; }
    }
}
