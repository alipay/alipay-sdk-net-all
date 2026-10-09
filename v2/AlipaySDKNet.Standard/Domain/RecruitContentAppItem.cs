using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecruitContentAppItem Data Structure.
    /// </summary>
    [Serializable]
    public class RecruitContentAppItem : AopObject
    {
        /// <summary>
        /// 小程序商品配置信息列表。
        /// </summary>
        [XmlArray("content_configs")]
        [XmlArrayItem("recruit_content_config")]
        public List<RecruitContentConfig> ContentConfigs { get; set; }

        /// <summary>
        /// 支付宝侧的商品ID。推荐传item_id。
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 商家侧小程序商品的spu，即商家侧小程序商品id。
        /// </summary>
        [XmlElement("out_item_id")]
        public string OutItemId { get; set; }

        /// <summary>
        /// 商家侧小程序商品归属的小程序ID。
        /// </summary>
        [XmlElement("related_app_id")]
        public string RelatedAppId { get; set; }
    }
}
