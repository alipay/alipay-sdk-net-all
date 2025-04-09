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
        /// 第三方配送商物流单号
        /// </summary>
        [XmlElement("carrier_order_no")]
        public string CarrierOrderNo { get; set; }

        /// <summary>
        /// 订单全部的商品信息
        /// </summary>
        [XmlArray("items")]
        [XmlArrayItem("waybill_item_v_o")]
        public List<WaybillItemVO> Items { get; set; }

        /// <summary>
        /// 订单号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }
    }
}
