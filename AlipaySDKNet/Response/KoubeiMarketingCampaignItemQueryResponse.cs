using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiMarketingCampaignItemQueryResponse.
    /// </summary>
    public class KoubeiMarketingCampaignItemQueryResponse : AopResponse
    {
        /// <summary>
        /// 商品详情，包含门店信息
        /// </summary>
        [XmlElement("item")]
        public PromoItemInfo Item { get; set; }
    }
}
