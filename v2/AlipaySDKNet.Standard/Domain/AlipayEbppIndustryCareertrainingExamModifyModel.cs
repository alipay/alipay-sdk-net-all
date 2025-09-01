using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppIndustryCareertrainingExamModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustryCareertrainingExamModifyModel : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("certificate_code_list")]
        [XmlArrayItem("string")]
        public List<string> CertificateCodeList { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("city_code_list")]
        [XmlArrayItem("string")]
        public List<string> CityCodeList { get; set; }

        /// <summary>
        /// 考试描述
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 考试详情文本
        /// </summary>
        [XmlElement("details")]
        public string Details { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("exam_attrs")]
        [XmlArrayItem("exam_attrs_item_v_o")]
        public List<ExamAttrsItemVO> ExamAttrs { get; set; }

        /// <summary>
        /// 评价业务主键
        /// </summary>
        [XmlElement("exam_id")]
        public string ExamId { get; set; }

        /// <summary>
        /// 评价名称
        /// </summary>
        [XmlElement("exam_name")]
        public string ExamName { get; set; }

        /// <summary>
        /// 考试时间描述
        /// </summary>
        [XmlElement("exam_time_notes")]
        public string ExamTimeNotes { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("head_image_list")]
        [XmlArrayItem("string")]
        public List<string> HeadImageList { get; set; }

        /// <summary>
        /// 考试定价(最大值) 单位:分
        /// </summary>
        [XmlElement("max_price")]
        public long MaxPrice { get; set; }

        /// <summary>
        /// 考试定价(最小值) 单位:分
        /// </summary>
        [XmlElement("min_price")]
        public long MinPrice { get; set; }

        /// <summary>
        /// yyyy-MM-dd  格式时间
        /// </summary>
        [XmlElement("registration_end_date")]
        public string RegistrationEndDate { get; set; }

        /// <summary>
        /// 报考须知
        /// </summary>
        [XmlElement("registration_notes")]
        public string RegistrationNotes { get; set; }

        /// <summary>
        /// 报考要求
        /// </summary>
        [XmlElement("registration_requirement")]
        public string RegistrationRequirement { get; set; }

        /// <summary>
        /// yyyy-MM-dd  格式时间
        /// </summary>
        [XmlElement("registration_start_date")]
        public string RegistrationStartDate { get; set; }

        /// <summary>
        /// 报考流程
        /// </summary>
        [XmlElement("registration_steps")]
        public string RegistrationSteps { get; set; }

        /// <summary>
        /// 内部备注
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 考试详情URL
        /// </summary>
        [XmlElement("service_url")]
        public string ServiceUrl { get; set; }
    }
}
