using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PunishBreakInfo Data Structure.
    /// </summary>
    [Serializable]
    public class PunishBreakInfo : AopObject
    {
        /// <summary>
        /// 法定代表人或负责人姓名
        /// </summary>
        [XmlElement("business_entity")]
        public string BusinessEntity { get; set; }

        /// <summary>
        /// 身份证号码或工商注册号
        /// </summary>
        [XmlElement("card_num")]
        public string CardNum { get; set; }

        /// <summary>
        /// 案号
        /// </summary>
        [XmlElement("case_code")]
        public string CaseCode { get; set; }

        /// <summary>
        /// 执行法院
        /// </summary>
        [XmlElement("court_name")]
        public string CourtName { get; set; }

        /// <summary>
        /// 失信被执行人行为具体情形
        /// </summary>
        [XmlElement("disrupt_type_name")]
        public string DisruptTypeName { get; set; }

        /// <summary>
        /// 生效法律文书确定的义务
        /// </summary>
        [XmlElement("duty")]
        public string Duty { get; set; }

        /// <summary>
        /// 执行依据文号
        /// </summary>
        [XmlElement("gist_id")]
        public string GistId { get; set; }

        /// <summary>
        /// 做出执行依据单位
        /// </summary>
        [XmlElement("gist_unit")]
        public string GistUnit { get; set; }

        /// <summary>
        /// 被执行人姓名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 被执行人履行情况
        /// </summary>
        [XmlElement("performance")]
        public string Performance { get; set; }

        /// <summary>
        /// 已履行金额（元）
        /// </summary>
        [XmlElement("performed_part")]
        public string PerformedPart { get; set; }

        /// <summary>
        /// 省份
        /// </summary>
        [XmlElement("province")]
        public string Province { get; set; }

        /// <summary>
        /// 发布时间。格式yyyy-MM-dd
        /// </summary>
        [XmlElement("publish_date")]
        public string PublishDate { get; set; }

        /// <summary>
        /// 立案时间. 格式yyyy-MM-dd
        /// </summary>
        [XmlElement("reg_case_date")]
        public string RegCaseDate { get; set; }

        /// <summary>
        /// 失信人类型
        /// </summary>
        [XmlElement("trpe")]
        public string Trpe { get; set; }

        /// <summary>
        /// 失信人类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 未履行金额（元）
        /// </summary>
        [XmlElement("un_perform_part")]
        public string UnPerformPart { get; set; }
    }
}
