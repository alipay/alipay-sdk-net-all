using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalPaymentOrderSyncResponse.
    /// </summary>
    public class AlipayCommerceMedicalPaymentOrderSyncResponse : AopResponse
    {
        /// <summary>
        /// 上传成功后的平台订单Id
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }
    }
}
