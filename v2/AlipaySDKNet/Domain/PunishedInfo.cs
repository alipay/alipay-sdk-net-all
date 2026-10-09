using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PunishedInfo Data Structure.
    /// </summary>
    [Serializable]
    public class PunishedInfo : AopObject
    {
        /// <summary>
        /// 身份证号或工商注册号
        /// </summary>
        [XmlElement("card_num")]
        public string CardNum { get; set; }

        /// <summary>
        /// 案号
        /// </summary>
        [XmlElement("case_code")]
        public string CaseCode { get; set; }

        /// <summary>
        /// 案件状态
        /// </summary>
        [XmlElement("case_status")]
        public string CaseStatus { get; set; }

        /// <summary>
        /// 执行法院
        /// </summary>
        [XmlElement("court_name")]
        public string CourtName { get; set; }

        /// <summary>
        /// 执行标的（元）
        /// </summary>
        [XmlElement("exec_money")]
        public string ExecMoney { get; set; }

        /// <summary>
        /// 被执行人姓名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 省份
        /// </summary>
        [XmlElement("province")]
        public string Province { get; set; }

        /// <summary>
        /// 立案时间. 格式yyyy-MM-dd
        /// </summary>
        [XmlElement("reg_case_date")]
        public string RegCaseDate { get; set; }

        /// <summary>
        /// 失信人类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
