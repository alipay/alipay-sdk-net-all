using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FilterConfig Data Structure.
    /// </summary>
    [Serializable]
    public class FilterConfig : AopObject
    {
        /// <summary>
        /// 数据
        /// </summary>
        [XmlElement("data")]
        public FilterDataConfig Data { get; set; }

        /// <summary>
        /// 图标
        /// </summary>
        [XmlElement("icon")]
        public string Icon { get; set; }

        /// <summary>
        /// 榜单配置key
        /// </summary>
        [XmlElement("key")]
        public string Key { get; set; }

        /// <summary>
        /// 价格
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 榜单配置显示文本
        /// </summary>
        [XmlElement("text")]
        public string Text { get; set; }
    }
}
