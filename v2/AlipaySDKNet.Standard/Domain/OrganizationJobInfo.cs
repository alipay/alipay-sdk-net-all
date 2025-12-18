using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OrganizationJobInfo Data Structure.
    /// </summary>
    [Serializable]
    public class OrganizationJobInfo : AopObject
    {
        /// <summary>
        /// 岗位学历要求
        /// </summary>
        [XmlElement("academic_require")]
        public string AcademicRequire { get; set; }

        /// <summary>
        /// 年龄范围（单位：岁）， 其他示例： 不限,不限  18,不限  不限,60
        /// </summary>
        [XmlElement("age")]
        public string Age { get; set; }

        /// <summary>
        /// 雇主企业品牌logo
        /// </summary>
        [XmlElement("brand_logo")]
        public string BrandLogo { get; set; }

        /// <summary>
        /// 雇主企业品牌名称
        /// </summary>
        [XmlElement("brand_name")]
        public string BrandName { get; set; }

        /// <summary>
        /// 岗位行政地区编码 </br> <a href="https://jiuye.yuque.com/org-wiki-jiuye-cpfcqs/araxo9/ed5yn3asbtes7ni4" target="_blank">全量城市行政区划编码（2022Q2版本） </a></br> <a href="https://jiuye.yuque.com/org-wiki-jiuye-cpfcqs/araxo9/yi0uix3f0babcfzi" target="_blank">全量区县行政区划编码（2022Q2版本） </a>
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 招聘人数，为0或为空时不限人数
        /// </summary>
        [XmlElement("count")]
        public long Count { get; set; }

        /// <summary>
        /// 雇主企业信用代码
        /// </summary>
        [XmlElement("employer_cert_no")]
        public string EmployerCertNo { get; set; }

        /// <summary>
        /// 雇主名称(企业名称)
        /// </summary>
        [XmlElement("employer_name")]
        public string EmployerName { get; set; }

        /// <summary>
        /// 经纬度（经度,纬度）,逗号分隔
        /// </summary>
        [XmlElement("geo")]
        public string Geo { get; set; }

        /// <summary>
        /// 岗位详情跳转地址
        /// </summary>
        [XmlElement("job_detail_url")]
        public string JobDetailUrl { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("job_features")]
        [XmlArrayItem("string")]
        public List<string> JobFeatures { get; set; }

        /// <summary>
        /// 支付宝岗位id
        /// </summary>
        [XmlElement("job_id")]
        public string JobId { get; set; }

        /// <summary>
        /// 岗位名称
        /// </summary>
        [XmlElement("job_name")]
        public string JobName { get; set; }

        /// <summary>
        /// 岗位类型编码 </br> <a href="https://jiuye.yuque.com/org-wiki-jiuye-cpfcqs/araxo9/nmowzfqvl8itkado" target="_blank">岗位类型清单</a>
        /// </summary>
        [XmlElement("job_type")]
        public string JobType { get; set; }

        /// <summary>
        /// 岗位类型名称
        /// </summary>
        [XmlElement("job_type_name")]
        public string JobTypeName { get; set; }

        /// <summary>
        /// 服务商名称（简称或全称）
        /// </summary>
        [XmlElement("partner_name")]
        public string PartnerName { get; set; }

        /// <summary>
        /// 薪资结算方式
        /// </summary>
        [XmlElement("pay_period")]
        public string PayPeriod { get; set; }

        /// <summary>
        /// 薪资范围（单位：元），最小薪资和最大薪资逗号分隔
        /// </summary>
        [XmlElement("salary")]
        public string Salary { get; set; }

        /// <summary>
        /// 岗位就业模式
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
