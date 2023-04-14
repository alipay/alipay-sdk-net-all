using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniMarketReceivedConsultResponse.
    /// </summary>
    public class AlipayOpenMiniMarketReceivedConsultResponse : AopResponse
    {
        /// <summary>
        /// true为已经领过券，false为未领取
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
