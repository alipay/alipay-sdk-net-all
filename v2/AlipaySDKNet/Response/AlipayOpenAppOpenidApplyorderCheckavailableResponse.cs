using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenAppOpenidApplyorderCheckavailableResponse.
    /// </summary>
    public class AlipayOpenAppOpenidApplyorderCheckavailableResponse : AopResponse
    {
        /// <summary>
        /// 最近创建的10条工单状态信息
        /// </summary>
        [XmlArray("order_list")]
        [XmlArrayItem("open_id_order")]
        public List<OpenIdOrder> OrderList { get; set; }
    }
}
