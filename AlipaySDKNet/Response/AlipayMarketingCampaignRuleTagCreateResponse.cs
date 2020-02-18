using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingCampaignRuleTagCreateResponse.
    /// </summary>
    public class AlipayMarketingCampaignRuleTagCreateResponse : AopResponse
    {
        /// <summary>
        /// 自定义标签id（创建自定义规则时提供）
        /// </summary>
        [XmlElement("customertag")]
        public string Customertag { get; set; }
    }
}
