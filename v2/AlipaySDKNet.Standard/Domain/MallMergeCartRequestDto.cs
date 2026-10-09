using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MallMergeCartRequestDto Data Structure.
    /// </summary>
    [Serializable]
    public class MallMergeCartRequestDto : AopObject
    {
        /// <summary>
        /// app_code，用于合并购物车
        /// </summary>
        [XmlElement("app_code")]
        public string AppCode { get; set; }

        /// <summary>
        /// fix_user_id，用于合并购物车
        /// </summary>
        [XmlElement("fix_user_id")]
        public string FixUserId { get; set; }

        /// <summary>
        /// 用于合并购物车
        /// </summary>
        [XmlArray("items")]
        [XmlArrayItem("mall_item_dtos")]
        public List<MallItemDtos> Items { get; set; }

        /// <summary>
        /// order_id，用于合并购物车
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }
    }
}
