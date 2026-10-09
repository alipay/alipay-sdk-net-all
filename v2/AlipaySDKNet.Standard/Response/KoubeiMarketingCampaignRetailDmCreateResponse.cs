using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiMarketingCampaignRetailDmCreateResponse.
    /// </summary>
    public class KoubeiMarketingCampaignRetailDmCreateResponse : AopResponse
    {
        /// <summary>
        /// 内容id：该活动/商品入库成功之后，会将该活动/商品的id返回，作为商品/活动的内容id
        /// </summary>
        [XmlElement("content_id")]
        public string ContentId { get; set; }

        /// <summary>
        /// 扩展信息：活动返回的额外的信息，如果创建活动的时候有传入扩展备用信息，返回就存在，如果创建没有填该字段，返回也不会有该字段
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }
    }
}
