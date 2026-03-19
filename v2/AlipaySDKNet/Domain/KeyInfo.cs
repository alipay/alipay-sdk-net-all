using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KeyInfo Data Structure.
    /// </summary>
    [Serializable]
    public class KeyInfo : AopObject
    {
        /// <summary>
        /// 条件是否变更
        /// </summary>
        [XmlElement("filter_change")]
        public bool FilterChange { get; set; }

        /// <summary>
        /// tab页数据缓存key
        /// </summary>
        [XmlElement("page_key")]
        public string PageKey { get; set; }

        /// <summary>
        /// 缓存数据类型
        /// </summary>
        [XmlElement("search_type")]
        public string SearchType { get; set; }

        /// <summary>
        /// 二级缓存
        /// </summary>
        [XmlElement("second_page_key")]
        public string SecondPageKey { get; set; }
    }
}
