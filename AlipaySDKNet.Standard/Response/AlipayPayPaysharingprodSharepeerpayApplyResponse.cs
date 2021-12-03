using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPayPaysharingprodSharepeerpayApplyResponse.
    /// </summary>
    public class AlipayPayPaysharingprodSharepeerpayApplyResponse : AopResponse
    {
        /// <summary>
        /// 代付单号
        /// </summary>
        [XmlElement("peerpay_order_no")]
        public string PeerpayOrderNo { get; set; }
    }
}
