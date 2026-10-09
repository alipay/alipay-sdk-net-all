using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EpDishonestDefendantInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EpDishonestDefendantInfo : AopObject
    {
        /// <summary>
        /// 被执行人的履行情况
        /// </summary>
        [XmlElement("bzxrdlxqk")]
        public string Bzxrdlxqk { get; set; }

        /// <summary>
        /// 案号
        /// </summary>
        [XmlElement("case_no")]
        public string CaseNo { get; set; }

        /// <summary>
        /// 立案时间
        /// </summary>
        [XmlElement("case_register_date")]
        public string CaseRegisterDate { get; set; }

        /// <summary>
        /// 执行法院
        /// </summary>
        [XmlElement("execution_court")]
        public string ExecutionCourt { get; set; }

        /// <summary>
        /// 法定代表人或者负责人姓名
        /// </summary>
        [XmlElement("fddbr")]
        public string Fddbr { get; set; }

        /// <summary>
        /// 发布时间
        /// </summary>
        [XmlElement("issue_date")]
        public string IssueDate { get; set; }

        /// <summary>
        /// 省份
        /// </summary>
        [XmlElement("province")]
        public string Province { get; set; }

        /// <summary>
        /// 被执行人姓名/名称
        /// </summary>
        [XmlElement("sxbzxrmc")]
        public string Sxbzxrmc { get; set; }

        /// <summary>
        /// 失信被执行人行为具体情形
        /// </summary>
        [XmlElement("sxbzxrxw")]
        public string Sxbzxrxw { get; set; }

        /// <summary>
        /// 生效法律文书确定的义务
        /// </summary>
        [XmlElement("sxflwsyw")]
        public string Sxflwsyw { get; set; }

        /// <summary>
        /// 做出执行依据单位
        /// </summary>
        [XmlElement("zczxyjdw")]
        public string Zczxyjdw { get; set; }

        /// <summary>
        /// 执行依据文号
        /// </summary>
        [XmlElement("zxyjwh")]
        public string Zxyjwh { get; set; }
    }
}
