using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DeliveryInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class DeliveryInfoVO : AopObject
    {
        /// <summary>
        /// 快递公司ID，通过获取快递公司列表获取
        /// </summary>
        [XmlElement("delivery_id")]
        public string DeliveryId { get; set; }

        /// <summary>
        /// 商品信息
        /// </summary>
        [XmlArray("item_info_list")]
        [XmlArrayItem("delivery_item_info_v_o")]
        public List<DeliveryItemInfoVO> ItemInfoList { get; set; }

        /// <summary>
        /// 快递单号
        /// </summary>
        [XmlElement("waybill_id")]
        public string WaybillId { get; set; }
    }
}
