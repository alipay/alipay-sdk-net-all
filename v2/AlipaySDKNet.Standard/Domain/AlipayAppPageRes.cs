using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayAppPageRes Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayAppPageRes : AopObject
    {
        /// <summary>
        /// 标题链接
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 应用标识
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 小程序位置
        /// </summary>
        [XmlElement("page_type")]
        public string PageType { get; set; }

        /// <summary>
        /// 跳转链接
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
