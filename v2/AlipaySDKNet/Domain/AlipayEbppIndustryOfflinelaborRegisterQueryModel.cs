using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppIndustryOfflinelaborRegisterQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustryOfflinelaborRegisterQueryModel : AopObject
    {
        /// <summary>
        /// 登记状态
        /// </summary>
        [XmlElement("application_status")]
        public string ApplicationStatus { get; set; }

        /// <summary>
        /// 岗位Id（服务商内部岗位 Id）对应 out_job_id
        /// </summary>
        [XmlElement("job_id")]
        public string JobId { get; set; }

        /// <summary>
        /// 岗位名，支持模糊搜索
        /// </summary>
        [XmlElement("job_name")]
        public string JobName { get; set; }

        /// <summary>
        /// 外部登记号
        /// </summary>
        [XmlElement("out_regist_no")]
        public string OutRegistNo { get; set; }

        /// <summary>
        /// 页码（从 1 开始）
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 页面记录（最大 50 ）
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 项目Id（服务商内部项目 Id） 对应 out_project_id
        /// </summary>
        [XmlElement("project_id")]
        public string ProjectId { get; set; }

        /// <summary>
        /// 项目名，支持模糊搜索
        /// </summary>
        [XmlElement("project_name")]
        public string ProjectName { get; set; }

        /// <summary>
        /// 登记结束时间 (yyyy-MM-dd HH:mm:ss)
        /// </summary>
        [XmlElement("reg_end_date")]
        public string RegEndDate { get; set; }

        /// <summary>
        /// 登记起始时间 (yyyy-MM-dd HH:mm:ss)
        /// </summary>
        [XmlElement("reg_start_date")]
        public string RegStartDate { get; set; }

        /// <summary>
        /// 用户姓名，支持精确搜索
        /// </summary>
        [XmlElement("user_name")]
        public string UserName { get; set; }

        /// <summary>
        /// 用户手机号码，支持精确搜索
        /// </summary>
        [XmlElement("user_phone_number")]
        public string UserPhoneNumber { get; set; }
    }
}
