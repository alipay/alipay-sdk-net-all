using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalDoctorinfoBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalDoctorinfoBatchqueryModel : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("doctorid_list")]
        [XmlArrayItem("string")]
        public List<string> DoctoridList { get; set; }
    }
}
