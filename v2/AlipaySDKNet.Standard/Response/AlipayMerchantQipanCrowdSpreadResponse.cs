using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantQipanCrowdSpreadResponse.
    /// </summary>
    public class AlipayMerchantQipanCrowdSpreadResponse : AopResponse
    {
        /// <summary>
        /// 人群编号
        /// </summary>
        [XmlElement("crowd_code")]
        public string CrowdCode { get; set; }
    }
}
