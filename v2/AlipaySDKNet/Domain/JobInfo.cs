using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// JobInfo Data Structure.
    /// </summary>
    [Serializable]
    public class JobInfo : AopObject
    {
        /// <summary>
        /// 岗位地址（行政区域）
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 年龄范围
        /// </summary>
        [XmlElement("age_range")]
        public string AgeRange { get; set; }

        /// <summary>
        /// 用户岗位申请状态 APPLYING：已申请/已报名
        /// </summary>
        [XmlElement("apply_status")]
        public string ApplyStatus { get; set; }

        /// <summary>
        /// 福利补贴信息
        /// </summary>
        [XmlElement("bonus_desc")]
        public string BonusDesc { get; set; }

        /// <summary>
        /// 是否热门岗位，true表示热门岗位
        /// </summary>
        [XmlElement("hot_job")]
        public bool HotJob { get; set; }

        /// <summary>
        /// 岗位介绍，一段描述性文本，\n为换行符
        /// </summary>
        [XmlElement("introduction")]
        public string Introduction { get; set; }

        /// <summary>
        /// 岗位id，岗位的唯一标识
        /// </summary>
        [XmlElement("job_id")]
        public string JobId { get; set; }

        /// <summary>
        /// 岗位关键标签，不同标签用','分割
        /// </summary>
        [XmlElement("job_key_tags")]
        public string JobKeyTags { get; set; }

        /// <summary>
        /// 岗位名称
        /// </summary>
        [XmlElement("job_name")]
        public string JobName { get; set; }

        /// <summary>
        /// 职位供应商code
        /// </summary>
        [XmlElement("job_supplier_code")]
        public string JobSupplierCode { get; set; }

        /// <summary>
        /// 岗位全职兼职类型 ALL：兼职/全职 PART_TIME：兼职 FULL_TIME：全职
        /// </summary>
        [XmlElement("job_time_type")]
        public string JobTimeType { get; set; }

        /// <summary>
        /// 岗位种类
        /// </summary>
        [XmlElement("post")]
        public string Post { get; set; }

        /// <summary>
        /// 录用条件，一段描述性字符串，其中\n为换行符
        /// </summary>
        [XmlElement("recruit_condition")]
        public string RecruitCondition { get; set; }

        /// <summary>
        /// 基本薪资数额，单位元
        /// </summary>
        [XmlElement("salary")]
        public string Salary { get; set; }

        /// <summary>
        /// 薪资结算方式
        /// </summary>
        [XmlElement("salary_settlement_desc")]
        public string SalarySettlementDesc { get; set; }

        /// <summary>
        /// 性别范围
        /// </summary>
        [XmlElement("sex_range")]
        public string SexRange { get; set; }

        /// <summary>
        /// 一句话岗位描述
        /// </summary>
        [XmlElement("simple_desc")]
        public string SimpleDesc { get; set; }
    }
}
