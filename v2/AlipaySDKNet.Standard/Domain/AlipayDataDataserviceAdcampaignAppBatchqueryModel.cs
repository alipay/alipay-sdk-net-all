using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataserviceAdcampaignAppBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceAdcampaignAppBatchqueryModel : AopObject
    {
        /// <summary>
        /// 创意动作类型
        /// </summary>
        [XmlElement("action_type")]
        public string ActionType { get; set; }

        /// <summary>
        /// 商家tag
        /// </summary>
        [XmlElement("principal_tag")]
        public string PrincipalTag { get; set; }
    }
}
