using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AppItemNotifyDataVO Data Structure.
    /// </summary>
    [Serializable]
    public class AppItemNotifyDataVO : AopObject
    {
        /// <summary>
        /// 商品数据变更后内容
        /// </summary>
        [XmlElement("after")]
        public AppItemDataDiffVO After { get; set; }

        /// <summary>
        /// 商品数据变更前内容
        /// </summary>
        [XmlElement("before")]
        public AppItemDataDiffVO Before { get; set; }

        /// <summary>
        /// 商品数据变更所属的事件类型
        /// </summary>
        [XmlElement("event_type")]
        public string EventType { get; set; }

        /// <summary>
        /// 当前操作所发生的站点
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }
    }
}
