using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniShopRelationBindModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniShopRelationBindModel : AopObject
    {
        /// <summary>
        /// 门店信息，entity_id为平台侧门店id，property_list属性列表详见 <a href="https://opendocs.alipay.com/mini/00nvud">绑定门店</a>。
        /// </summary>
        [XmlArray("entity_info")]
        [XmlArrayItem("mini_entity_bind_info")]
        public List<MiniEntityBindInfo> EntityInfo { get; set; }

        /// <summary>
        /// 操作类型，固定为：MINIAPP_SHOP
        /// </summary>
        [XmlElement("operation")]
        public string Operation { get; set; }
    }
}
