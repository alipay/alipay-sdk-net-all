using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniItemPageQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniItemPageQueryModel : AopObject
    {
        /// <summary>
        /// 商家侧商品id列表
        /// </summary>
        [XmlArray("item_id_list")]
        [XmlArrayItem("string")]
        public List<string> ItemIdList { get; set; }

        /// <summary>
        /// 操作类型，固定为：ITEM_PAGEQUERY
        /// </summary>
        [XmlElement("operation")]
        public string Operation { get; set; }

        /// <summary>
        /// 当前页码，默认1
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页数量，最大不超过20，默认10
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }
    }
}
