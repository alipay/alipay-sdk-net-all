using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingActivityOrdervoucherReceiveResponse.
    /// </summary>
    public class AlipayMarketingActivityOrdervoucherReceiveResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("receive_result_list")]
        [XmlArrayItem("order_voucher_receive_result")]
        public List<OrderVoucherReceiveResult> ReceiveResultList { get; set; }
    }
}
