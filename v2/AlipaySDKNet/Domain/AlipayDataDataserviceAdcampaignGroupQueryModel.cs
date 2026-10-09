using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataserviceAdcampaignGroupQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceAdcampaignGroupQueryModel : AopObject
    {
        /// <summary>
        /// 单元id
        /// </summary>
        [XmlElement("group_id")]
        public long GroupId { get; set; }

        /// <summary>
        /// 商家tag
        /// </summary>
        [XmlElement("principal_tag")]
        public string PrincipalTag { get; set; }
    }
}
