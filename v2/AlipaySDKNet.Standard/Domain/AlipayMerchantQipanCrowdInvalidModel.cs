using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantQipanCrowdInvalidModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantQipanCrowdInvalidModel : AopObject
    {
        /// <summary>
        /// 支付宝人群code
        /// </summary>
        [XmlElement("crowd_code")]
        public string CrowdCode { get; set; }
    }
}
