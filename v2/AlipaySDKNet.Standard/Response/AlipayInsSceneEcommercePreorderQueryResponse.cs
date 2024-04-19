using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsSceneEcommercePreorderQueryResponse.
    /// </summary>
    public class AlipayInsSceneEcommercePreorderQueryResponse : AopResponse
    {
        /// <summary>
        /// 预下单列表
        /// </summary>
        [XmlArray("pre_orders")]
        [XmlArrayItem("ins_pre_order_d_t_o")]
        public List<InsPreOrderDTO> PreOrders { get; set; }
    }
}
