using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppIndustryJobDailySyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustryJobDailySyncModel : AopObject
    {
        /// <summary>
        /// 学历要求
        /// </summary>
        [XmlElement("academic_require")]
        public string AcademicRequire { get; set; }

        /// <summary>
        /// 岗位详细地址,线下岗位的经纬度、区县字段改为必填。
        /// </summary>
        [XmlElement("address")]
        public JobAddress Address { get; set; }

        /// <summary>
        /// 年龄范围 格式：最小年龄（含）,最大年龄（含） 如果没有限制，则传不限。 其他示例： 不限,不限 18,不限 不限,60，单位：年
        /// </summary>
        [XmlElement("age")]
        public string Age { get; set; }

        /// <summary>
        /// 招聘，单位：个
        /// </summary>
        [XmlElement("count")]
        public long Count { get; set; }

        /// <summary>
        /// 雇主名称 请使用企业工商注册名，不要使用简称或品牌名称
        /// </summary>
        [XmlElement("employer_name")]
        public string EmployerName { get; set; }

        /// <summary>
        /// 雇主类型
        /// </summary>
        [XmlElement("employer_type")]
        public string EmployerType { get; set; }

        /// <summary>
        /// 岗位招聘信息失效时间
        /// </summary>
        [XmlElement("expired_date")]
        public string ExpiredDate { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        [XmlElement("gender")]
        public string Gender { get; set; }

        /// <summary>
        /// 岗位状态
        /// </summary>
        [XmlElement("hire_status")]
        public string HireStatus { get; set; }

        /// <summary>
        /// 岗位详情内容，必填
        /// </summary>
        [XmlElement("job_detail")]
        public string JobDetail { get; set; }

        /// <summary>
        /// 岗位的小程序详情页URL URL链接处理可以参考：<a href="https://opendocs.alipay.com/support/01rb18" target="_blank" >小程序scheme链接介绍</a>
        /// </summary>
        [XmlElement("job_detail_url")]
        public string JobDetailUrl { get; set; }

        /// <summary>
        /// 福利待遇 内容标签最多5个，每个标签最多7个中文字符，如：["包吃住","工资日结","五险一金"]
        /// </summary>
        [XmlArray("job_features")]
        [XmlArrayItem("string")]
        public List<string> JobFeatures { get; set; }

        /// <summary>
        /// 岗位名称 用于页面展示
        /// </summary>
        [XmlElement("job_name")]
        public string JobName { get; set; }

        /// <summary>
        /// 工作要求
        /// </summary>
        [XmlArray("job_requires")]
        [XmlArrayItem("string")]
        public List<string> JobRequires { get; set; }

        /// <summary>
        /// 岗位类型 用于岗位筛选、岗位匹配等场景，具体枚举值清单如下（传第三级岗位类型Code）：<a href="https://jiuye.yuque.com/org-wiki-jiuye-cpfcqs/araxo9/nmowzfqvl8itkado" target="_blank">岗位类型清单</a>
        /// </summary>
        [XmlElement("job_type")]
        public string JobType { get; set; }

        /// <summary>
        /// 商户侧的岗位唯一标识
        /// </summary>
        [XmlElement("out_job_id")]
        public string OutJobId { get; set; }

        /// <summary>
        /// 岗位就业模式
        /// </summary>
        [XmlElement("part_time_mode")]
        public string PartTimeMode { get; set; }

        /// <summary>
        /// 薪资单位，单位：周、日、小时
        /// </summary>
        [XmlElement("pay_period")]
        public string PayPeriod { get; set; }

        /// <summary>
        /// 薪资范围 格式：最低薪资（含）,最高薪资（含），薪资结算方式是面议时为空。 如果为单价型岗位，最低薪资和最高薪资内容保持一致，如: 800,800。单位：元
        /// </summary>
        [XmlElement("salary")]
        public string Salary { get; set; }

        /// <summary>
        /// 岗位来源，如安心快招渠道
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 岗位招聘信息生效时间
        /// </summary>
        [XmlElement("start_date")]
        public string StartDate { get; set; }

        /// <summary>
        /// 工作时段-结束时间，单位：小时
        /// </summary>
        [XmlElement("work_interval_end")]
        public string WorkIntervalEnd { get; set; }

        /// <summary>
        /// 工作时段-开始时间,单位：小时
        /// </summary>
        [XmlElement("work_interval_start")]
        public string WorkIntervalStart { get; set; }

        /// <summary>
        /// 是否在线办公 是传true，否传false
        /// </summary>
        [XmlElement("work_online")]
        public bool WorkOnline { get; set; }

        /// <summary>
        /// 工作年限要求，单位：年
        /// </summary>
        [XmlElement("working_years")]
        public string WorkingYears { get; set; }
    }
}
