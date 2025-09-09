using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalOrderLogisticsSyncResponse.
    /// </summary>
    public class AlipayCommerceMedicalOrderLogisticsSyncResponse : AopResponse
    {
        /// <summary>
        /// true/false
        /// </summary>
        [XmlElement("data")]
        public bool Data { get; set; }
    }
}
