using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalHmPrescriptionQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalHmPrescriptionQueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("prescription_infos")]
        [XmlArrayItem("prescription_info")]
        public List<PrescriptionInfo> PrescriptionInfos { get; set; }
    }
}
