using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalIndustrydataDiseaseUploadModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalIndustrydataDiseaseUploadModel : AopObject
    {
        /// <summary>
        /// 疾病信息
        /// </summary>
        [XmlArray("disease_list")]
        [XmlArrayItem("disease_base_data")]
        public List<DiseaseBaseData> DiseaseList { get; set; }

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
