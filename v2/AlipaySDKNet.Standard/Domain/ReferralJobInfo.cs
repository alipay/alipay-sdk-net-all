using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ReferralJobInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ReferralJobInfo : AopObject
    {
        /// <summary>
        /// 学历要求
        /// </summary>
        [XmlElement("academic_require")]
        public string AcademicRequire { get; set; }

        /// <summary>
        /// 详细地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 地址名称
        /// </summary>
        [XmlElement("address_name")]
        public string AddressName { get; set; }

        /// <summary>
        /// 年龄要求
        /// </summary>
        [XmlElement("age")]
        public string Age { get; set; }

        /// <summary>
        /// 传入经纬度时返回距离，单位为米
        /// </summary>
        [XmlElement("distance")]
        public long Distance { get; set; }

        /// <summary>
        /// 传入经纬度时返回展示文案
        /// </summary>
        [XmlElement("distance_display")]
        public string DistanceDisplay { get; set; }

        /// <summary>
        /// 招聘结束时间，格式为yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("expire_date")]
        public string ExpireDate { get; set; }

        /// <summary>
        /// 岗位经纬度，格式为经度,纬度
        /// </summary>
        [XmlElement("geo")]
        public string Geo { get; set; }

        /// <summary>
        /// 职位描述
        /// </summary>
        [XmlElement("job_desc")]
        public string JobDesc { get; set; }

        /// <summary>
        /// 岗位ID
        /// </summary>
        [XmlElement("job_id")]
        public string JobId { get; set; }

        /// <summary>
        /// 岗位名称
        /// </summary>
        [XmlElement("job_name")]
        public string JobName { get; set; }

        /// <summary>
        /// 岗位类型
        /// </summary>
        [XmlElement("job_type")]
        public string JobType { get; set; }

        /// <summary>
        /// 发薪日期
        /// </summary>
        [XmlElement("pay_date")]
        public string PayDate { get; set; }

        /// <summary>
        /// 结算方式
        /// </summary>
        [XmlElement("pay_period")]
        public string PayPeriod { get; set; }

        /// <summary>
        /// 平台名称
        /// </summary>
        [XmlElement("platform_name")]
        public string PlatformName { get; set; }

        /// <summary>
        /// 招聘人数
        /// </summary>
        [XmlElement("recruitment_count")]
        public long RecruitmentCount { get; set; }

        /// <summary>
        /// 薪资范围，单位：元
        /// </summary>
        [XmlElement("salary")]
        public string Salary { get; set; }

        /// <summary>
        /// 薪资单位
        /// </summary>
        [XmlElement("salary_unit")]
        public string SalaryUnit { get; set; }

        /// <summary>
        /// 站点名称
        /// </summary>
        [XmlElement("station_name")]
        public string StationName { get; set; }

        /// <summary>
        /// 工作性质
        /// </summary>
        [XmlElement("work_nature")]
        public string WorkNature { get; set; }
    }
}
