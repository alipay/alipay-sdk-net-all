using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalServicepackageListQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalServicepackageListQueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("specialty_disease_package_list")]
        [XmlArrayItem("specialty_disease_package")]
        public List<SpecialtyDiseasePackage> SpecialtyDiseasePackageList { get; set; }
    }
}
