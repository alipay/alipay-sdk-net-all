using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEnergyReceiveSendResponse.
    /// </summary>
    public class AlipayCommerceEnergyReceiveSendResponse : AopResponse
    {
        /// <summary>
        /// 交易订单中，对应的商品列表中有对应的环保类型，能量发放结果;
        /// </summary>
        [XmlArray("order_good_list")]
        [XmlArrayItem("order_good_d_t_o")]
        public List<OrderGoodDTO> OrderGoodList { get; set; }

        /// <summary>
        /// 能量发放总克数
        /// </summary>
        [XmlElement("total_energy_amount")]
        public string TotalEnergyAmount { get; set; }
    }
}
