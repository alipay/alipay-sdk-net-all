using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOfflineSmddOrderListQueryResponse.
    /// </summary>
    public class AlipayOfflineSmddOrderListQueryResponse : AopResponse
    {
        /// <summary>
        /// 订单列表
        /// </summary>
        [XmlArray("order_list")]
        [XmlArrayItem("order_bean")]
        public List<OrderBean> OrderList { get; set; }
    }
}
