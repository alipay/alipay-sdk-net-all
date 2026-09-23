using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalOrderWaybillSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalOrderWaybillSyncModel : AopObject
    {
        /// <summary>
        /// 第三方配送商物流单号（整单使用）
        /// </summary>
        [XmlElement("carrier_order_no")]
        public string CarrierOrderNo { get; set; }

        /// <summary>
        /// 订单全部的商品信息（整单使用）
        /// </summary>
        [XmlArray("items")]
        [XmlArrayItem("waybill_item_v_o")]
        public List<WaybillItemVO> Items { get; set; }

        /// <summary>
        /// 订单号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 拆分订单的多物流信息列表（拆单使用）
        /// </summary>
        [XmlArray("shipment_list")]
        [XmlArrayItem("shipment_v_o")]
        public List<ShipmentVO> ShipmentList { get; set; }
    }
}
