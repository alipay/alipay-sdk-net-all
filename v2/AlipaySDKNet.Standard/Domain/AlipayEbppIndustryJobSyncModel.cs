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
        /// 不限      UNLIMITED 高中      H 技校      T 中专      S 大专      C 本科      B 硕士      M 博士      D
        /// </summary>
        [XmlElement("academic_require")]
        public string AcademicRequire { get; set; }

        /// <summary>
        /// 岗位详细地址。 如果是线下岗位，则传具体岗位地址信息 如果是线上岗位，则传空
        /// </summary>
        [XmlElement("address")]
        public JobAddress Address { get; set; }

        /// <summary>
        /// 年龄范围。 格式：最小年龄（含）,最大年龄（含） 如果没有限制，则传不限。  其他示例： 不限,不限 18,不限 不限,60
        /// </summary>
        [XmlElement("age")]
        public string Age { get; set; }

        /// <summary>
        /// 技能、证书等要求，比如学历、健康证、普通话或其他技能证书等。部分枚举值： 健康证 本科 专科 普通话
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
        /// 雇主名称，请使用企业工商注册名
        /// </summary>
        [XmlElement("employer_name")]
        public string EmployerName { get; set; }

        /// <summary>
        /// 雇主类型： COMPANY：企业 INDIVIDUAL_BUSINESS：个体户 PERSON：个人
        /// </summary>
        [XmlElement("employer_type")]
        public string EmployerType { get; set; }

        /// <summary>
        /// 岗位招聘信息失效时间。
        /// </summary>
        [XmlElement("expired_date")]
        public string ExpiredDate { get; set; }

        /// <summary>
        /// 性别： ALL：不限年龄 MALE：男 FEMALE：女
        /// </summary>
        [XmlElement("gender")]
        public string Gender { get; set; }

        /// <summary>
        /// 岗位状态： HIRING：招聘中 CLOSED：招聘结束
        /// </summary>
        [XmlElement("hire_status")]
        public string HireStatus { get; set; }

        /// <summary>
        /// 岗位详情内容
        /// </summary>
        [XmlElement("job_detail")]
        public string JobDetail { get; set; }

        /// <summary>
        /// 岗位的小程序详情页URL，地址处理可以参考：https://opendocs.alipay.com/support/01rb18
        /// </summary>
        [XmlElement("job_detail_url")]
        public string JobDetailUrl { get; set; }

        /// <summary>
        /// 岗位特性，内容标签最多只能有7个字，如：["包吃住","工资日结xxxxxxxxx"] 只保留：["包吃住"]
        /// </summary>
        [XmlArray("job_features")]
        [XmlArrayItem("string")]
        public List<string> JobFeatures { get; set; }

        /// <summary>
        /// 岗位名称，用于页面展示。
        /// </summary>
        [XmlElement("job_name")]
        public string JobName { get; set; }

        /// <summary>
        /// 岗位标签，标签为枚举值，“大学生”、“退役军人”、“特殊人群”、”乡村”，如同步这些标签，会提高透出权重
        /// </summary>
        [XmlArray("job_tags")]
        [XmlArrayItem("string")]
        public List<string> JobTags { get; set; }

        /// <summary>
        /// 岗位类型，用于岗位筛选、岗位匹配等场景，具体枚举值在集成阶段提供
        /// </summary>
        [XmlElement("job_type")]
        public string JobType { get; set; }

        /// <summary>
        /// 岗位是否要求应聘人有芝麻工作证。  枚举值： MUST：必须有芝麻工作证 RECOMMEND：优先考虑有芝麻工作证 NO_REQ：不要求芝麻工作证  如果还没有对接芝麻工作证，则传NO_REQ，等对接后再调整。
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
        /// 薪资结算方式: 小时结 日结 周结 月结 项目结 按件结 面议
        /// </summary>
        [XmlElement("pay_period")]
        public string PayPeriod { get; set; }

        /// <summary>
        /// 岗位优先级， 在以下类型中选择： 1：高优先级 2：中优先级 3：低优先级 建议只将少量岗位设置为高优先级，否则这个优先级的效果会低于预期。
        /// </summary>
        [XmlElement("priority")]
        public long Priority { get; set; }

        /// <summary>
        /// 薪资范围，格式：最低薪资（含）,最高薪资（含），薪资结算方式是面议时为空。最高薪资不超过5万。如果为单价型岗位，最低薪资和最高薪资内容保持一致，如: 800,800
        /// </summary>
        [XmlElement("salary")]
        public string Salary { get; set; }

        /// <summary>
        /// 岗位招聘信息生效时间.
        /// </summary>
        [XmlElement("start_date")]
        public string StartDate { get; set; }

        /// <summary>
        /// 是否在线办公，是则传true，否则传false
        /// </summary>
        [XmlElement("work_online")]
        public bool WorkOnline { get; set; }

        /// <summary>
        /// 不限       UNLIMITED 1年以下    LESS_THAN_ONE_YEAR 1-2年      ONE_TO_TWO 3-5年      THREE_TO_FIVE 6-7年      SIX_TO_SEVEN 8-10年     EIGHT_TO_TEN 10年以上   MORE_THAN_TEN_YEARS
        /// </summary>
        [XmlElement("working_years")]
        public string WorkingYears { get; set; }
    }
}
