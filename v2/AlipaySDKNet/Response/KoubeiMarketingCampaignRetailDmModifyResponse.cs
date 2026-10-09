using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiMarketingCampaignRetailDmModifyResponse.
    /// </summary>
    public class KoubeiMarketingCampaignRetailDmModifyResponse : AopResponse
    {
        /// <summary>
        /// 内容id：该活动/商品入库成功之后，会将该活动/商品的id返回，作为商品/活动的内容id
        /// </summary>
        [XmlElement("content_id")]
        public string ContentId { get; set; }
    }
}
