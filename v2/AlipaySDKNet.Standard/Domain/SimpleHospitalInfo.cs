using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SimpleHospitalInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SimpleHospitalInfo : AopObject
    {
        /// <summary>
        /// String 好大夫医院id
        /// </summary>
        [XmlElement("hospital_id")]
        public string HospitalId { get; set; }

        /// <summary>
        /// 医院名称
        /// </summary>
        [XmlElement("hospital_name")]
        public string HospitalName { get; set; }
    }
}
