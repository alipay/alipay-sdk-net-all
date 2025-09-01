using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppIndustryCareertrainingExamQueryResponse.
    /// </summary>
    public class AlipayEbppIndustryCareertrainingExamQueryResponse : AopResponse
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
        /// 评价id
        /// </summary>
        [XmlElement("exam_id")]
        public string ExamId { get; set; }

        /// <summary>
        /// 考试事项名称
        /// </summary>
        [XmlElement("exam_name")]
        public string ExamName { get; set; }

        /// <summary>
        /// 考试状态
        /// </summary>
        [XmlElement("exam_status")]
        public string ExamStatus { get; set; }

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
        /// 考试定价(最大值)，单位分 maxPrice和minPrice都填写时, minPrice<=maxPrice
        /// </summary>
        [XmlElement("max_price")]
        public long MaxPrice { get; set; }

        /// <summary>
        /// 考试定价(最小值) ，单位分 非必填 
        /// </summary>
        [XmlElement("min_price")]
        public long MinPrice { get; set; }

        /// <summary>
        /// 考试提交机构 示例: G202507250000001
        /// </summary>
        [XmlElement("org_code")]
        public string OrgCode { get; set; }

        /// <summary>
        /// 外部评价id
        /// </summary>
        [XmlElement("out_exam_id")]
        public string OutExamId { get; set; }

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
