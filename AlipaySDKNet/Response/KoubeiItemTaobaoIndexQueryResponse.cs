using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiItemTaobaoIndexQueryResponse.
    /// </summary>
    public class KoubeiItemTaobaoIndexQueryResponse : AopResponse
    {
        /// <summary>
        /// 栏目名称
        /// </summary>
        [XmlElement("column_title")]
        public string ColumnTitle { get; set; }

        /// <summary>
        /// 扩展信息，json格式
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 商品信息列表
        /// </summary>
        [XmlArray("item_list")]
        [XmlArrayItem("kb_item_info")]
        public List<KbItemInfo> ItemList { get; set; }

        /// <summary>
        /// 时段图标
        /// </summary>
        [XmlElement("time_icon")]
        public string TimeIcon { get; set; }

        /// <summary>
        /// 时段名称
        /// </summary>
        [XmlElement("time_title")]
        public string TimeTitle { get; set; }

        /// <summary>
        /// 商品列表页地址
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
