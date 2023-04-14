using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalIndustrydataInquirydoctorstatusUploadModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalIndustrydataInquirydoctorstatusUploadModel : AopObject
    {
        /// <summary>
        /// 医生问诊状态信息列表
        /// </summary>
        [XmlArray("doctor_status_list")]
        [XmlArrayItem("inquery_doctor_status_data")]
        public List<InqueryDoctorStatusData> DoctorStatusList { get; set; }

        /// <summary>
        /// 问诊平台编码
        /// </summary>
        [XmlElement("platform_code")]
        public string PlatformCode { get; set; }
    }
}
