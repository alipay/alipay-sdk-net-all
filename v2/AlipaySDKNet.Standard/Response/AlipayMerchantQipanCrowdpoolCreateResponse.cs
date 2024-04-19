using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantQipanCrowdpoolCreateResponse.
    /// </summary>
    public class AlipayMerchantQipanCrowdpoolCreateResponse : AopResponse
    {
        /// <summary>
        /// 棋盘人群编号
        /// </summary>
        [XmlElement("crowd_code")]
        public string CrowdCode { get; set; }
    }
}
