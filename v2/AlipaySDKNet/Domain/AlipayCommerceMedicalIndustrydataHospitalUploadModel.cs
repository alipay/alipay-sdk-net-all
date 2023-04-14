using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalIndustrydataHospitalUploadModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalIndustrydataHospitalUploadModel : AopObject
    {
        /// <summary>
        /// 医院信息
        /// </summary>
        [XmlArray("hospital_list")]
        [XmlArrayItem("hospital_data")]
        public List<HospitalData> HospitalList { get; set; }

        /// <summary>
        /// isvpid
        /// </summary>
        [XmlElement("isv_pid")]
        public string IsvPid { get; set; }

        /// <summary>
        /// 请求id，保证每次请求唯一
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }
    }
}
