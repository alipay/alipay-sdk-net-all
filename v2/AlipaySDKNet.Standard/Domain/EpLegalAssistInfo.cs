using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EpLegalAssistInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EpLegalAssistInfo : AopObject
    {
        /// <summary>
        /// 受让人
        /// </summary>
        [XmlElement("assignee")]
        public string Assignee { get; set; }

        /// <summary>
        /// 冻结期限，单位天
        /// </summary>
        [XmlElement("djqx")]
        public string Djqx { get; set; }

        /// <summary>
        /// 股权冻结起始日期
        /// </summary>
        [XmlElement("djzxzi")]
        public string Djzxzi { get; set; }

        /// <summary>
        /// 执行事项
        /// </summary>
        [XmlElement("enforcement_actions")]
        public string EnforcementActions { get; set; }

        /// <summary>
        /// 执行法院
        /// </summary>
        [XmlElement("execution_court")]
        public string ExecutionCourt { get; set; }

        /// <summary>
        /// 股权冻结状态
        /// </summary>
        [XmlElement("gqdjzt")]
        public string Gqdjzt { get; set; }

        /// <summary>
        /// 股权所在企业名称
        /// </summary>
        [XmlElement("gqszqymc")]
        public string Gqszqymc { get; set; }

        /// <summary>
        /// 被执行人
        /// </summary>
        [XmlElement("person_subject_to_enforcement")]
        public string PersonSubjectToEnforcement { get; set; }

        /// <summary>
        /// 公示日期
        /// </summary>
        [XmlElement("publicity_date")]
        public string PublicityDate { get; set; }

        /// <summary>
        /// 司法协助类型
        /// </summary>
        [XmlElement("sfxzlx")]
        public string Sfxzlx { get; set; }

        /// <summary>
        /// 股权数额，单位万元
        /// </summary>
        [XmlElement("stock_right_sum")]
        public string StockRightSum { get; set; }

        /// <summary>
        /// 股权冻结结束日期
        /// </summary>
        [XmlElement("zjqxzhi")]
        public string Zjqxzhi { get; set; }

        /// <summary>
        /// 执行裁定书文号
        /// </summary>
        [XmlElement("zxcdswh")]
        public string Zxcdswh { get; set; }

        /// <summary>
        /// 执行通知书文号
        /// </summary>
        [XmlElement("zxtzswh")]
        public string Zxtzswh { get; set; }
    }
}
