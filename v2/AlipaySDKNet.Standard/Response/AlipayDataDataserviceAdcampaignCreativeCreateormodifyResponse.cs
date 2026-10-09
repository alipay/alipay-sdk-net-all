using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataserviceAdcampaignCreativeCreateormodifyResponse.
    /// </summary>
    public class AlipayDataDataserviceAdcampaignCreativeCreateormodifyResponse : AopResponse
    {
        /// <summary>
        /// 创意id
        /// </summary>
        [XmlElement("creative_id")]
        public long CreativeId { get; set; }

        /// <summary>
        /// 创意名称
        /// </summary>
        [XmlElement("creative_name")]
        public string CreativeName { get; set; }
    }
}
