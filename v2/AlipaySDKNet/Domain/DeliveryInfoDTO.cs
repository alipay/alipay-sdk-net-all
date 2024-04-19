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
        /// 快递公司ID列表请查看：https://opendocs.alipay.com/mini/07hva0?pathHash=5de3c48d，请确认传入的值在此列表内，若发货的快递公司不在此列表内，可以传入值other
        /// </summary>
        [XmlElement("delivery_id")]
        public string DeliveryId { get; set; }

        /// <summary>
        /// 商品信息
        /// </summary>
        [XmlArray("item_info_list")]
        [XmlArrayItem("goods_item_d_t_o")]
        public List<GoodsItemDTO> ItemInfoList { get; set; }

        /// <summary>
        /// 发货期数
        /// </summary>
        [XmlElement("period")]
        public string Period { get; set; }

        /// <summary>
        /// 快递单号
        /// </summary>
        [XmlElement("waybill_id")]
        public string WaybillId { get; set; }
    }
}
