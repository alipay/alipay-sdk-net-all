using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppRoomrentListQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppRoomrentListQueryModel : AopObject
    {
        /// <summary>
        /// 支付宝平台侧商品ID列表，最多20个。
        /// </summary>
        [XmlArray("item_id_list")]
        [XmlArrayItem("string")]
        public List<string> ItemIdList { get; set; }

        /// <summary>
        /// 支付宝商家侧商品ID列表，最多20个。
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
        /// 审核驳回：商品审核失败时，商品状态为审核驳回。 审核中：商品处于审核流程中时，商品状态为审核中。 已下架：商家可以通过调用接口下架商品，也可以通过商家后台下架商品。 可售卖：商家可以通过调用接口上架商品，也可以通过商家后台上架商品。 冻结：当商家出现违规操作时，支付宝侧将发起冻结，商品无法对外透出。 当商品包含多个规格时，只要有一个规格的商品状态为“可售卖”，spu的商品状态则为“可售卖”。
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
