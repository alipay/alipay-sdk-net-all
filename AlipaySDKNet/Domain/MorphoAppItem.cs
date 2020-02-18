using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MorphoAppItem Data Structure.
    /// </summary>
    [Serializable]
    public class MorphoAppItem : AopObject
    {
        /// <summary>
        /// 应用更新时间
        /// </summary>
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 闪蝶应用ID
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 小程序源数据
        /// </summary>
        [XmlElement("mini_meta")]
        public MorphoMiniMeta MiniMeta { get; set; }

        /// <summary>
        /// 应用上线状态
        /// </summary>
        [XmlElement("online_state")]
        public long OnlineState { get; set; }

        /// <summary>
        /// 闪蝶用户数据
        /// </summary>
        [XmlElement("owner")]
        public MorphoUser Owner { get; set; }

        /// <summary>
        /// 应用状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 闪蝶应用名称
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 应用类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
