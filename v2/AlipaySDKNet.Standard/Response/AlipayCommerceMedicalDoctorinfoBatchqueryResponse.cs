using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalDoctorinfoBatchqueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalDoctorinfoBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("doctor_info_list")]
        [XmlArrayItem("doctor_basic_info")]
        public List<DoctorBasicInfo> DoctorInfoList { get; set; }
    }
}
