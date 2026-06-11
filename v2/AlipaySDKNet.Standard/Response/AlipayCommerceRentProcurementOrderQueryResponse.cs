using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceRentProcurementOrderQueryResponse.
    /// </summary>
    public class AlipayCommerceRentProcurementOrderQueryResponse : AopResponse
    {
        /// <summary>
        /// 附加文件信息
        /// </summary>
        [XmlElement("additional_media_info")]
        public RentProcurementAdditionalMediaInfoVO AdditionalMediaInfo { get; set; }

        /// <summary>
        /// 收货信息
        /// </summary>
        [XmlElement("address_info")]
        public RentProcurementAddressInfoVO AddressInfo { get; set; }

        /// <summary>
        /// 取消状态
        /// </summary>
        [XmlElement("cancel_status")]
        public string CancelStatus { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("delivery_infos")]
        [XmlArrayItem("rent_procurement_delivery_info_v_o")]
        public List<RentProcurementDeliveryInfoVO> DeliveryInfos { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("device_infos")]
        [XmlArrayItem("rent_procurement_device_info_v_o")]
        public List<RentProcurementDeviceInfoVO> DeviceInfos { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("item_infos")]
        [XmlArrayItem("rent_procurement_item_info_v_o")]
        public List<RentProcurementItemInfoVO> ItemInfos { get; set; }

        /// <summary>
        /// 商家采购订单ID
        /// </summary>
        [XmlElement("out_procurement_order_id")]
        public string OutProcurementOrderId { get; set; }

        /// <summary>
        /// 商家租赁订单ID
        /// </summary>
        [XmlElement("out_rent_order_id")]
        public string OutRentOrderId { get; set; }

        /// <summary>
        /// 金额信息
        /// </summary>
        [XmlElement("price_info")]
        public RentProcurementPriceInfoVO PriceInfo { get; set; }

        /// <summary>
        /// 采购发起方（PLATFORM_ESCROW-平台托管采购 / MERCHANT-自行发起采购）
        /// </summary>
        [XmlElement("procurement_initiator")]
        public string ProcurementInitiator { get; set; }

        /// <summary>
        /// 平台采购订单ID
        /// </summary>
        [XmlElement("procurement_order_id")]
        public string ProcurementOrderId { get; set; }

        /// <summary>
        /// 退款信息
        /// </summary>
        [XmlElement("refund_info")]
        public RentProcurementRefundInfoVO RefundInfo { get; set; }

        /// <summary>
        /// 租赁订单ID
        /// </summary>
        [XmlElement("relate_rent_order_id")]
        public string RelateRentOrderId { get; set; }

        /// <summary>
        /// 采购单状态（CREATED/PAID/SUPPLIER_CONFIRMED/DELIVERED/RECEIVED/CLOSED）
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
