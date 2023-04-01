using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DeliveryInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class DeliveryInfoDTO : AopObject
    {
        /// <summary>
        /// 232
        /// </summary>
        [XmlElement("delivery_id")]
        public string DeliveryId { get; set; }

        /// <summary>
        /// 是 商品信息
        /// </summary>
        [XmlArray("item_info_list")]
        [XmlArrayItem("goods_item_d_t_o")]
        public List<GoodsItemDTO> ItemInfoList { get; set; }

        /// <summary>
        /// 快递单号
        /// </summary>
        [XmlElement("waybill_id")]
        public string WaybillId { get; set; }
    }
}
