using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppIndustryJobOrganizationQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustryJobOrganizationQueryModel : AopObject
    {
        /// <summary>
        /// 学历要求
        /// </summary>
        [XmlElement("academic_require")]
        public string AcademicRequire { get; set; }

        /// <summary>
        /// 身份证号码
        /// </summary>
        [XmlElement("cert_num")]
        public string CertNum { get; set; }

        /// <summary>
        /// 城市行政区划编码 </br> <a href="https://jiuye.yuque.com/org-wiki-jiuye-cpfcqs/araxo9/ed5yn3asbtes7ni4" target="_blank">全量城市行政区划编码（2022Q2版本） </a></br> <a href="https://jiuye.yuque.com/org-wiki-jiuye-cpfcqs/araxo9/yi0uix3f0babcfzi" target="_blank">全量区县行政区划编码（2022Q2版本） </a>
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 设备号内容
        /// </summary>
        [XmlElement("device_id")]
        public string DeviceId { get; set; }

        /// <summary>
        /// 设备号类型
        /// </summary>
        [XmlElement("device_id_type")]
        public string DeviceIdType { get; set; }

        /// <summary>
        /// 经纬度（经度,纬度）,逗号分隔
        /// </summary>
        [XmlElement("geo")]
        public string Geo { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("job_types")]
        [XmlArrayItem("string")]
        public List<string> JobTypes { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [XmlElement("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 支付宝用户id
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 分页页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 分页记录条数
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 薪资上限（单位：元）
        /// </summary>
        [XmlElement("salary_max")]
        public string SalaryMax { get; set; }

        /// <summary>
        /// 薪资下限（单位：元）
        /// </summary>
        [XmlElement("salary_min")]
        public string SalaryMin { get; set; }

        /// <summary>
        /// 搜索词，当前搜索岗位类型名称、岗位名称、雇主名称、岗位特性
        /// </summary>
        [XmlElement("search_word")]
        public string SearchWord { get; set; }

        /// <summary>
        /// 岗位排序规则，附近-按照用户经纬度进行排序，最新-按照岗位更新时间进行排序，默认根据更新时间进行排序
        /// </summary>
        [XmlElement("sort_type")]
        public string SortType { get; set; }

        /// <summary>
        /// 支付宝用户id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 工作模式
        /// </summary>
        [XmlElement("work_nature")]
        public string WorkNature { get; set; }

        /// <summary>
        /// 工作年限要求
        /// </summary>
        [XmlElement("working_years")]
        public string WorkingYears { get; set; }
    }
}
