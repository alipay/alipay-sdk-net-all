using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudpromoMallPurchaseConsultResponse.
    /// </summary>
    public class AlipayCloudCloudpromoMallPurchaseConsultResponse : AopResponse
    {
        /// <summary>
        /// 地址列表
        /// </summary>
        [XmlElement("address_list")]
        public MpcAddressInfo AddressList { get; set; }

        /// <summary>
        /// 是否可售
        /// </summary>
        [XmlElement("can_sell")]
        public bool CanSell { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [XmlElement("message")]
        public string Message { get; set; }

        /// <summary>
        /// 可售列表
        /// </summary>
        [XmlArray("order_list")]
        [XmlArrayItem("single_order_v_o")]
        public List<SingleOrderVO> OrderList { get; set; }

        /// <summary>
        /// 不可售列表
        /// </summary>
        [XmlElement("unsellable_order_list")]
        public SingleOrderVO UnsellableOrderList { get; set; }
    }
}
