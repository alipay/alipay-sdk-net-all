using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ItemEnrollFreezeContent Data Structure.
    /// </summary>
    [Serializable]
    public class ItemEnrollFreezeContent : AopObject
    {
        /// <summary>
        /// 是否参与直播秒杀
        /// </summary>
        [XmlElement("in_live")]
        public bool InLive { get; set; }

        /// <summary>
        /// 是否投放招商
        /// </summary>
        [XmlElement("item_enroll_flag")]
        public bool ItemEnrollFlag { get; set; }

        /// <summary>
        /// 不允许编辑字段列表
        /// </summary>
        [XmlArray("no_edit_key_list")]
        [XmlArrayItem("string")]
        public List<string> NoEditKeyList { get; set; }

        /// <summary>
        /// 用于对外透出文案
        /// </summary>
        [XmlArray("no_edit_tip_list")]
        [XmlArrayItem("string")]
        public List<string> NoEditTipList { get; set; }

        /// <summary>
        /// 提示信息&跳转链接
        /// </summary>
        [XmlArray("tips_and_urls")]
        [XmlArrayItem("tips_and_url")]
        public List<TipsAndUrl> TipsAndUrls { get; set; }
    }
}
