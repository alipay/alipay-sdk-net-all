using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalInquiryDepartmentSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalInquiryDepartmentSyncModel : AopObject
    {
        /// <summary>
        /// 科室地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 年龄限制（0：无限制；1:14 周岁以上；2:18 周岁以上）
        /// </summary>
        [XmlElement("age_restriction")]
        public string AgeRestriction { get; set; }

        /// <summary>
        /// 数据版本号（毫秒级时间戳）
        /// </summary>
        [XmlElement("data_version")]
        public string DataVersion { get; set; }

        /// <summary>
        /// 三方科室编码
        /// </summary>
        [XmlElement("department_id")]
        public string DepartmentId { get; set; }

        /// <summary>
        /// 三方科室名称
        /// </summary>
        [XmlElement("department_name")]
        public string DepartmentName { get; set; }

        /// <summary>
        /// 状态 (ONLINE/OFFLINE)
        /// </summary>
        [XmlElement("department_status")]
        public string DepartmentStatus { get; set; }

        /// <summary>
        /// 科室联系电话
        /// </summary>
        [XmlElement("dept_phone")]
        public string DeptPhone { get; set; }

        /// <summary>
        /// 科室排序值
        /// </summary>
        [XmlElement("dept_sort")]
        public string DeptSort { get; set; }

        /// <summary>
        /// 科室特色描述
        /// </summary>
        [XmlElement("dept_special")]
        public string DeptSpecial { get; set; }

        /// <summary>
        /// 科室介绍说明
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 性别限制（0：无限制；1：男性；2：女性）
        /// </summary>
        [XmlElement("gender_restriction")]
        public string GenderRestriction { get; set; }

        /// <summary>
        /// 三方医院编码
        /// </summary>
        [XmlElement("hospital_id")]
        public string HospitalId { get; set; }

        /// <summary>
        /// 服务商编码
        /// </summary>
        [XmlElement("isv_code")]
        public string IsvCode { get; set; }

        /// <summary>
        /// 科室层级
        /// </summary>
        [XmlElement("level")]
        public string Level { get; set; }

        /// <summary>
        /// 科室人数
        /// </summary>
        [XmlElement("member_count")]
        public string MemberCount { get; set; }

        /// <summary>
        /// 上级科室编码
        /// </summary>
        [XmlElement("parent_department_id")]
        public string ParentDepartmentId { get; set; }

        /// <summary>
        /// 父科室名称
        /// </summary>
        [XmlElement("parent_dept_name")]
        public string ParentDeptName { get; set; }

        /// <summary>
        /// 来源平台 code
        /// </summary>
        [XmlElement("platform_code")]
        public string PlatformCode { get; set; }

        /// <summary>
        /// 科室简称
        /// </summary>
        [XmlElement("short_name")]
        public string ShortName { get; set; }
    }
}
