using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalIndustrydataInquirydoctorUploadModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalIndustrydataInquirydoctorUploadModel : AopObject
    {
        /// <summary>
        /// 医生信息列表
        /// </summary>
        [XmlArray("doctor_list")]
        [XmlArrayItem("inquery_doctor_data")]
        public List<InqueryDoctorData> DoctorList { get; set; }

        /// <summary>
        /// 外部请求号
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 医生执业问诊平台编码
        /// </summary>
        [XmlElement("platform_code")]
        public string PlatformCode { get; set; }
    }
}
