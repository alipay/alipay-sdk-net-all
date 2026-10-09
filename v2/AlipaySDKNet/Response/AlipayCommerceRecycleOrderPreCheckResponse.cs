using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceRecycleOrderPreCheckResponse.
    /// </summary>
    public class AlipayCommerceRecycleOrderPreCheckResponse : AopResponse
    {
        /// <summary>
        /// 用来标识，当前工单或用户进件状态校验结果
        /// </summary>
        [XmlElement("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 用来标识，当前工单或用户进件状态校验结果的详细信息code
        /// </summary>
        [XmlElement("order_status_reason")]
        public string OrderStatusReason { get; set; }
    }
}
