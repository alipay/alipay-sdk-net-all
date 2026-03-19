using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalPromotionlinkGetResponse.
    /// </summary>
    public class AlipayCommerceMedicalPromotionlinkGetResponse : AopResponse
    {
        /// <summary>
        /// 推广短链
        /// </summary>
        [XmlElement("promotion_link")]
        public string PromotionLink { get; set; }
    }
}
