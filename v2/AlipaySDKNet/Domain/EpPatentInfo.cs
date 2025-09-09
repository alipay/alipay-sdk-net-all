using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EpPatentInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EpPatentInfo : AopObject
    {
        /// <summary>
        /// 地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 代理人
        /// </summary>
        [XmlElement("agent_person")]
        public string AgentPerson { get; set; }

        /// <summary>
        /// 申请日
        /// </summary>
        [XmlElement("application_day")]
        public string ApplicationDay { get; set; }

        /// <summary>
        /// 申请号
        /// </summary>
        [XmlElement("application_number")]
        public string ApplicationNumber { get; set; }

        /// <summary>
        /// 发明（设计）名称
        /// </summary>
        [XmlElement("fmsjmc")]
        public string Fmsjmc { get; set; }

        /// <summary>
        /// 国际分类
        /// </summary>
        [XmlElement("international_classification")]
        public string InternationalClassification { get; set; }

        /// <summary>
        /// 发明人
        /// </summary>
        [XmlElement("inventor")]
        public string Inventor { get; set; }

        /// <summary>
        /// 解密公告日
        /// </summary>
        [XmlElement("jmggr")]
        public string Jmggr { get; set; }

        /// <summary>
        /// Locarno分类
        /// </summary>
        [XmlElement("locarnofl")]
        public string Locarnofl { get; set; }

        /// <summary>
        /// 公告日
        /// </summary>
        [XmlElement("notice_date")]
        public string NoticeDate { get; set; }

        /// <summary>
        /// 专利类型
        /// </summary>
        [XmlElement("patent_type")]
        public string PatentType { get; set; }

        /// <summary>
        /// PCT国际申请公布号
        /// </summary>
        [XmlElement("pctgbsj")]
        public string Pctgbsj { get; set; }

        /// <summary>
        /// PCT进入国家阶段日
        /// </summary>
        [XmlElement("pctjrgjjdr")]
        public string Pctjrgjjdr { get; set; }

        /// <summary>
        /// PCT国际申请号
        /// </summary>
        [XmlElement("pctsqsj")]
        public string Pctsqsj { get; set; }

        /// <summary>
        /// 申请人
        /// </summary>
        [XmlElement("proposer")]
        public string Proposer { get; set; }

        /// <summary>
        /// 申请公布日
        /// </summary>
        [XmlElement("published_application_day")]
        public string PublishedApplicationDay { get; set; }

        /// <summary>
        /// 申请公布号
        /// </summary>
        [XmlElement("published_application_number")]
        public string PublishedApplicationNumber { get; set; }

        /// <summary>
        /// 审定公告日
        /// </summary>
        [XmlElement("sdggr")]
        public string Sdggr { get; set; }

        /// <summary>
        /// 授权公告号
        /// </summary>
        [XmlElement("sqggh")]
        public string Sqggh { get; set; }

        /// <summary>
        /// 授权公告日
        /// </summary>
        [XmlElement("sqggr")]
        public string Sqggr { get; set; }

        /// <summary>
        /// 摘要
        /// </summary>
        [XmlElement("summary")]
        public string Summary { get; set; }

        /// <summary>
        /// 优先权
        /// </summary>
        [XmlElement("yxq")]
        public string Yxq { get; set; }

        /// <summary>
        /// 专利代理机构
        /// </summary>
        [XmlElement("zldljg")]
        public string Zldljg { get; set; }

        /// <summary>
        /// 专利权人
        /// </summary>
        [XmlElement("zlqr")]
        public string Zlqr { get; set; }
    }
}
