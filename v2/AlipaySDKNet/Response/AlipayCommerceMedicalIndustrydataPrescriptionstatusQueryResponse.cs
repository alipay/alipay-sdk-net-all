using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalIndustrydataPrescriptionstatusQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalIndustrydataPrescriptionstatusQueryResponse : AopResponse
    {
        /// <summary>
        /// 处方状态
        /// </summary>
        [XmlElement("prescription_status")]
        public string PrescriptionStatus { get; set; }
    }
}
