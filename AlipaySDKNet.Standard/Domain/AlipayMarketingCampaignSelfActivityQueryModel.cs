using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingCampaignSelfActivityQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingCampaignSelfActivityQueryModel : AopObject
    {
        /// <summary>
        /// b.alipay.com 运营中心配置后台-活动详情-活动id
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 场景码：默认(DEFAULT) 场景码与业务类型相关，接入时候请务必和支付宝技术对接人确认，需要传入特定业务场景的场景码
        /// </summary>
        [XmlArray("scene_code")]
        [XmlArrayItem("string")]
        public List<string> SceneCode { get; set; }
    }
}
