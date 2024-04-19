using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankMarketingCampaignBkpromoguardbaseLmitemmodifySyncResponse.
    /// </summary>
    public class MybankMarketingCampaignBkpromoguardbaseLmitemmodifySyncResponse : AopResponse
    {
        /// <summary>
        /// request_id + 唯一 + LinkedMall商品修改同步场景 +返回请求中的服务标识
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }
    }
}
