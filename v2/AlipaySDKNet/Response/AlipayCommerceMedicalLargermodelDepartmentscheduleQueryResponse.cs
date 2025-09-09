using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalLargermodelDepartmentscheduleQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalLargermodelDepartmentscheduleQueryResponse : AopResponse
    {
        /// <summary>
        /// 会话id
        /// </summary>
        [XmlElement("chat_id")]
        public string ChatId { get; set; }

        /// <summary>
        /// 医院行政科室名称
        /// </summary>
        [XmlElement("department_name")]
        public string DepartmentName { get; set; }

        /// <summary>
        /// 是否还有更多数据
        /// </summary>
        [XmlElement("has_more")]
        public bool HasMore { get; set; }

        /// <summary>
        /// 医院主院名称
        /// </summary>
        [XmlElement("hospital_name")]
        public string HospitalName { get; set; }

        /// <summary>
        /// 灵知医院主院id
        /// </summary>
        [XmlElement("hospital_uinq_code")]
        public string HospitalUinqCode { get; set; }

        /// <summary>
        /// 分页key
        /// </summary>
        [XmlElement("page_key")]
        public string PageKey { get; set; }

        /// <summary>
        /// 医院排班列表
        /// </summary>
        [XmlArray("register_info_list")]
        [XmlArrayItem("hospital_campus_register_schedule_info_d_t_o")]
        public List<HospitalCampusRegisterScheduleInfoDTO> RegisterInfoList { get; set; }

        /// <summary>
        /// 科室排班列表页链接，由前端提供   1. 标准科室排班   2. 医院科室排班
        /// </summary>
        [XmlElement("schedule_page_url")]
        public string SchedulePageUrl { get; set; }

        /// <summary>
        /// 二级缓存页
        /// </summary>
        [XmlElement("second_page_key")]
        public string SecondPageKey { get; set; }

        /// <summary>
        /// 科室跳转链接，由前端提供 1. 标准科室列表页 无需锚定 2. 医院科室列表页，无需锚定
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
