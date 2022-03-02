using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalIndustrydataDoctorUploadModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalIndustrydataDoctorUploadModel : AopObject
    {
        /// <summary>
        /// 医生数据
        /// </summary>
        [XmlArray("doctor_list")]
        [XmlArrayItem("doctor_data")]
        public List<DoctorData> DoctorList { get; set; }

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
