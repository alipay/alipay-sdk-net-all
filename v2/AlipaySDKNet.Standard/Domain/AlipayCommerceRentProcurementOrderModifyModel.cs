using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceRentProcurementOrderModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceRentProcurementOrderModifyModel : AopObject
    {
        /// <summary>
        /// 收货地址
        /// </summary>
        [XmlElement("address_info")]
        public RentProcurementAddressInfoVO AddressInfo { get; set; }

        /// <summary>
        /// 商家采购订单ID
        /// </summary>
        [XmlElement("out_procurement_order_id")]
        public string OutProcurementOrderId { get; set; }

        /// <summary>
        /// 平台采购订单ID
        /// </summary>
        [XmlElement("procurement_order_id")]
        public string ProcurementOrderId { get; set; }

        /// <summary>
        /// 修改类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
