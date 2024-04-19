using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppIndustryJobSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustryJobSyncModel : AopObject
    {
        /// <summary>
        /// 学历要求
        /// </summary>
        [XmlElement("academic_require")]
        public string AcademicRequire { get; set; }

        /// <summary>
        /// 岗位详细地址 如果是线下岗位，则传具体岗位地址信息 如果是线上岗位，也需要传具体的region_code
        /// </summary>
        [XmlElement("address")]
        public JobAddress Address { get; set; }

        /// <summary>
        /// 年龄范围 格式：最小年龄（含）,最大年龄（含） 如果没有限制，则传不限。 其他示例： 不限,不限 18,不限 不限,60
        /// </summary>
        [XmlElement("age")]
        public string Age { get; set; }

        /// <summary>
        /// 字段已废弃，传值无效
        /// </summary>
        [XmlArray("certifications")]
        [XmlArrayItem("string")]
        public List<string> Certifications { get; set; }

        /// <summary>
        /// 招聘人数
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
        /// IoT专属岗位=1，非IoT专属岗位=0。该字段向IoT服务商定向开放，非IoT专属岗位可以无需传值，如果是IoT专属岗位，不会在支付宝就业小程序内展示
        /// </summary>
        [XmlElement("iot_status")]
        public long IotStatus { get; set; }

        /// <summary>
        /// 岗位详情内容
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
        /// 字段已废弃，传值无效
        /// </summary>
        [XmlArray("job_tags")]
        [XmlArrayItem("string")]
        public List<string> JobTags { get; set; }

        /// <summary>
        /// 岗位类型 用于岗位筛选、岗位匹配等场景，具体枚举值清单如下（传第三级岗位类型Code）：<a href="https://jiuye.yuque.com/org-wiki-jiuye-cpfcqs/araxo9/nmowzfqvl8itkado" target="_blank">岗位类型清单</a>
        /// </summary>
        [XmlElement("job_type")]
        public string JobType { get; set; }

        /// <summary>
        /// 岗位是否要求应聘人有芝麻工作证 如果还没有对接芝麻工作证，则传NO_REQ，等对接后再调整。
        /// </summary>
        [XmlElement("job_worth_req")]
        public string JobWorthReq { get; set; }

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
        /// 薪资单位
        /// </summary>
        [XmlElement("pay_period")]
        public string PayPeriod { get; set; }

        /// <summary>
        /// 字段已废弃，传值无效
        /// </summary>
        [XmlElement("priority")]
        public long Priority { get; set; }

        /// <summary>
        /// 薪资范围 格式：最低薪资（含）,最高薪资（含），薪资结算方式是面议时为空。 如果为单价型岗位，最低薪资和最高薪资内容保持一致，如: 800,800
        /// </summary>
        [XmlElement("salary")]
        public string Salary { get; set; }

        /// <summary>
        /// 岗位招聘信息生效时间
        /// </summary>
        [XmlElement("start_date")]
        public string StartDate { get; set; }

        /// <summary>
        /// 是否在线办公 是传true，否传false
        /// </summary>
        [XmlElement("work_online")]
        public bool WorkOnline { get; set; }

        /// <summary>
        /// 工作年限要求
        /// </summary>
        [XmlElement("working_years")]
        public string WorkingYears { get; set; }
    }
}
