using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayTradeCrowdConsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeCrowdConsultModel : AopObject
    {
        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识 当前字段已废弃(无需open_id)
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 表明这笔请求的场景，目前只支持aacProspectMarketing一个值，表示该场景为AAC潜客营销场景
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 表明着笔请求的场景，可以同时包含多个场景，目前支持 AAC潜客营销-aacProspectMarketing 未绑卡人群首绑营销-bindCard
        /// </summary>
        [XmlArray("scene_list")]
        [XmlArrayItem("string")]
        public List<string> SceneList { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
