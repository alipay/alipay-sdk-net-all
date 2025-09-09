using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalRegisterOrderSyncResponse.
    /// </summary>
    public class AlipayCommerceMedicalRegisterOrderSyncResponse : AopResponse
    {
        /// <summary>
        /// 支付宝订单唯一ID
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }
    }
}
