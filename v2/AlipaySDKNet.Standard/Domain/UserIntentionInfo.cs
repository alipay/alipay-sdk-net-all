using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// UserIntentionInfo Data Structure.
    /// </summary>
    [Serializable]
    public class UserIntentionInfo : AopObject
    {
        /// <summary>
        /// 城市编码
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 城市名称
        /// </summary>
        [XmlElement("city_name")]
        public string CityName { get; set; }

        /// <summary>
        /// 期望工作类型
        /// </summary>
        [XmlElement("expect_job_type")]
        public string ExpectJobType { get; set; }

        /// <summary>
        /// 期望薪资最大值，单位元
        /// </summary>
        [XmlElement("expect_salary_max")]
        public string ExpectSalaryMax { get; set; }

        /// <summary>
        /// 薪资最小值,单位元
        /// </summary>
        [XmlElement("expect_salary_min")]
        public string ExpectSalaryMin { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 工作性质
        /// </summary>
        [XmlElement("work_nature")]
        public string WorkNature { get; set; }
    }
}
