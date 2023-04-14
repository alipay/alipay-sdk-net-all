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
        /// 是否需要券核销范围信息（包括pid列表、门店id列表和小程序appid列表，由于字段可能较大默认不返回，业务方也请慎用。pid列表:PID，门店id列表:SHOP_ID，小程序appid列表:APP_ID）
        /// </summary>
        [XmlArray("need_use_scope_info")]
        [XmlArrayItem("string")]
        public List<string> NeedUseScopeInfo { get; set; }

        /// <summary>
        /// 场景码：默认(DEFAULT) 场景码与业务类型相关，接入时候请务必和支付宝技术对接人确认，需要传入特定业务场景的场景码
        /// </summary>
        [XmlArray("scene_code")]
        [XmlArrayItem("string")]
        public List<string> SceneCode { get; set; }
    }
}
