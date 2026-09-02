using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalRegisterLatestorderQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalRegisterLatestorderQueryResponse : AopResponse
    {
        /// <summary>
        /// 订单列表跳转链接
        /// </summary>
        [XmlElement("order_list_url")]
        public string OrderListUrl { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("register_order_list")]
        [XmlArrayItem("platform_register_order_list")]
        public List<PlatformRegisterOrderList> RegisterOrderList { get; set; }
    }
}
