using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataserviceAdcampaignAppeaseBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceAdcampaignAppeaseBatchqueryModel : AopObject
    {
        /// <summary>
        /// 动作类型
        /// </summary>
        [XmlElement("action_type")]
        public string ActionType { get; set; }

        /// <summary>
        /// 小程序应用标识
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 商家tag
        /// </summary>
        [XmlElement("principal_tag")]
        public string PrincipalTag { get; set; }
    }
}
