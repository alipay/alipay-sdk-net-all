using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniShopRelationQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniShopRelationQueryModel : AopObject
    {
        /// <summary>
        /// 门店 ID 列表。支付宝门店（蚂蚁门店）的 ShopID。
        /// </summary>
        [XmlArray("entity_id_list")]
        [XmlArrayItem("string")]
        public List<string> EntityIdList { get; set; }

        /// <summary>
        /// 操作类型，固定为：MINIAPP_SHOP_PAGEQUERY
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
