using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalIndustrydataDrugorderstatusSyncResponse.
    /// </summary>
    public class AlipayCommerceMedicalIndustrydataDrugorderstatusSyncResponse : AopResponse
    {
        /// <summary>
        /// 支付宝药品订单号
        /// </summary>
        [XmlElement("drug_order_id")]
        public string DrugOrderId { get; set; }
    }
}
