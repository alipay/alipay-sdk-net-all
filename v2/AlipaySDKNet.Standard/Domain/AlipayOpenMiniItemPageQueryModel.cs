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
        /// 商家侧商品 id 列表，最多可传入 20 个。导入商品信息时传入的商户自定义商品 id（item_id），传入后仅分页查询出对应商品信息。
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
        /// 查询起始页码，默认为第一页 1。
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
