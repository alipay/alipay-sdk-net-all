using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalIndustrydataDepartmentUploadModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalIndustrydataDepartmentUploadModel : AopObject
    {
        /// <summary>
        /// 科室数据
        /// </summary>
        [XmlArray("department_list")]
        [XmlArrayItem("department_data")]
        public List<DepartmentData> DepartmentList { get; set; }

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
