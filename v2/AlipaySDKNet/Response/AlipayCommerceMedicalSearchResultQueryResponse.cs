using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalSearchResultQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalSearchResultQueryResponse : AopResponse
    {
        /// <summary>
        /// 活动列表
        /// </summary>
        [XmlElement("activity_list")]
        public string ActivityList { get; set; }

        /// <summary>
        /// 科普内容
        /// </summary>
        [XmlElement("article_list")]
        public ArticleVo ArticleList { get; set; }

        /// <summary>
        /// 医生信息
        /// </summary>
        [XmlElement("doctor_info_list")]
        public SimpleDoctorInfo DoctorInfoList { get; set; }

        /// <summary>
        /// 是否有更多
        /// </summary>
        [XmlElement("has_more")]
        public bool HasMore { get; set; }

        /// <summary>
        /// 医院信息
        /// </summary>
        [XmlElement("hospital_list")]
        public SimpleHospitalInfo HospitalList { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("key_list")]
        [XmlArrayItem("key_info")]
        public List<KeyInfo> KeyList { get; set; }

        /// <summary>
        /// 就诊记录信息
        /// </summary>
        [XmlElement("medical_record_list")]
        public MedicalRecordVo MedicalRecordList { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("sort_list")]
        [XmlArrayItem("string")]
        public List<string> SortList { get; set; }

        /// <summary>
        /// 词条信息
        /// </summary>
        [XmlElement("term_list")]
        public Term TermList { get; set; }
    }
}
