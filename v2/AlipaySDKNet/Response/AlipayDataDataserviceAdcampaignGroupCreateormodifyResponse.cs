using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataserviceAdcampaignGroupCreateormodifyResponse.
    /// </summary>
    public class AlipayDataDataserviceAdcampaignGroupCreateormodifyResponse : AopResponse
    {
        /// <summary>
        /// 单元id
        /// </summary>
        [XmlElement("group_id")]
        public long GroupId { get; set; }

        /// <summary>
        /// 单元名称
        /// </summary>
        [XmlElement("group_name")]
        public string GroupName { get; set; }
    }
}
