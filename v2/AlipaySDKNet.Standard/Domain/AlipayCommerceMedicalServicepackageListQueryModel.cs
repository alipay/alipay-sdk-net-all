using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalServicepackageListQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalServicepackageListQueryModel : AopObject
    {
        /// <summary>
        /// 是否是买后
        /// </summary>
        [XmlElement("is_purchased")]
        public bool IsPurchased { get; set; }

        /// <summary>
        /// 领衔医生ID
        /// </summary>
        [XmlElement("lead_doctor_id")]
        public string LeadDoctorId { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("package_id_list")]
        [XmlArrayItem("string")]
        public List<string> PackageIdList { get; set; }
    }
}
