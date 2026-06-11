using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceRentProcurementOrderCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceRentProcurementOrderCreateModel : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("item_infos")]
        [XmlArrayItem("rent_procurement_item_info_d_t_o")]
        public List<RentProcurementItemInfoDTO> ItemInfos { get; set; }

        /// <summary>
        /// 商户外部采购单号，保证幂等
        /// </summary>
        [XmlElement("out_procurement_order_id")]
        public string OutProcurementOrderId { get; set; }

        /// <summary>
        /// 收货人信息
        /// </summary>
        [XmlElement("receiver_info")]
        public RentProcurementReceiverInfoDTO ReceiverInfo { get; set; }

        /// <summary>
        /// 关联的租赁订单号
        /// </summary>
        [XmlElement("relate_rent_order_id")]
        public string RelateRentOrderId { get; set; }
    }
}
