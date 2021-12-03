using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsSceneFamilydoctorItemBatchqueryResponse.
    /// </summary>
    public class AlipayInsSceneFamilydoctorItemBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 药品列表
        /// </summary>
        [XmlArray("drugs")]
        [XmlArrayItem("health_service_family_doctor_drug_d_t_o")]
        public List<HealthServiceFamilyDoctorDrugDTO> Drugs { get; set; }
    }
}
