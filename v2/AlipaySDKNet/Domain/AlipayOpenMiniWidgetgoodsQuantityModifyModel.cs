using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniWidgetgoodsQuantityModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniWidgetgoodsQuantityModifyModel : AopObject
    {
        /// <summary>
        /// 商品的唯一标识，根据该字段修改商品
        /// </summary>
        [XmlElement("goods_id")]
        public string GoodsId { get; set; }

        /// <summary>
        /// 已售数量
        /// </summary>
        [XmlElement("sold_quantity")]
        public long SoldQuantity { get; set; }

        /// <summary>
        /// 总库存量
        /// </summary>
        [XmlElement("total_quantity")]
        public long TotalQuantity { get; set; }
    }
}
