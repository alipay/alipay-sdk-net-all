using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankMarketingCampaignBkpromosceneorderPointQueryResponse.
    /// </summary>
    public class MybankMarketingCampaignBkpromosceneorderPointQueryResponse : AopResponse
    {
        /// <summary>
        /// 用户当前的可用积分
        /// </summary>
        [XmlElement("point")]
        public long Point { get; set; }
    }
}
