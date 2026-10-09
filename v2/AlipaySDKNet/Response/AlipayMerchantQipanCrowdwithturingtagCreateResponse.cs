using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantQipanCrowdwithturingtagCreateResponse.
    /// </summary>
    public class AlipayMerchantQipanCrowdwithturingtagCreateResponse : AopResponse
    {
        /// <summary>
        /// 圈选出的人群id
        /// </summary>
        [XmlElement("crowd_id")]
        public string CrowdId { get; set; }
    }
}
