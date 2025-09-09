using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalIndustrydataOrderdeleteSyncResponse.
    /// </summary>
    public class AlipayCommerceMedicalIndustrydataOrderdeleteSyncResponse : AopResponse
    {
        /// <summary>
        /// 支付宝问诊单id
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }
    }
}
