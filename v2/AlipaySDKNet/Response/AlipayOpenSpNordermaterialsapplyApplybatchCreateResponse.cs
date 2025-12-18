using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenSpNordermaterialsapplyApplybatchCreateResponse.
    /// </summary>
    public class AlipayOpenSpNordermaterialsapplyApplybatchCreateResponse : AopResponse
    {
        /// <summary>
        /// 组合单号：组合下单时需要申请单号，后续下单需要携带此单号
        /// </summary>
        [XmlElement("combined_order_no")]
        public string CombinedOrderNo { get; set; }
    }
}
