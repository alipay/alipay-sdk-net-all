using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppItemListQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppItemListQueryModel : AopObject
    {
        /// <summary>
        /// 支付宝平台侧spu 商品id 列表，最多20个。
        /// </summary>
        [XmlArray("item_id_list")]
        [XmlArrayItem("string")]
        public List<string> ItemIdList { get; set; }

        /// <summary>
        /// 商家侧spu 商品id 列表，最多20个。 与platform_item_id_list二选一。如果都传，优先使用商家侧商品id。
        /// </summary>
        [XmlArray("out_item_id_list")]
        [XmlArrayItem("string")]
        public List<string> OutItemIdList { get; set; }

        /// <summary>
        /// 查询页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 查询分页单页数量，不超过20
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// spu商品状态
        /// </summary>
        [XmlElement("spu_status")]
        public string SpuStatus { get; set; }
    }
}
