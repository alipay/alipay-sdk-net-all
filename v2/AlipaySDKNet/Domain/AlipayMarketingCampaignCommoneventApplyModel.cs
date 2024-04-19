using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingCampaignCommoneventApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingCampaignCommoneventApplyModel : AopObject
    {
        /// <summary>
        /// 与event关联的数据
        /// </summary>
        [XmlElement("content_json")]
        public string ContentJson { get; set; }

        /// <summary>
        /// 事件类型
        /// </summary>
        [XmlElement("event")]
        public string Event { get; set; }
    }
}
