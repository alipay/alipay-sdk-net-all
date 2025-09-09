using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EpLitigationNoticeInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EpLitigationNoticeInfo : AopObject
    {
        /// <summary>
        /// 正文
        /// </summary>
        [XmlElement("body")]
        public string Body { get; set; }

        /// <summary>
        /// 当事人
        /// </summary>
        [XmlArray("parties")]
        [XmlArrayItem("string")]
        public List<string> Parties { get; set; }

        /// <summary>
        /// 公告时间
        /// </summary>
        [XmlElement("proclamation_date")]
        public string ProclamationDate { get; set; }

        /// <summary>
        /// 公告人
        /// </summary>
        [XmlElement("proclamation_people")]
        public string ProclamationPeople { get; set; }

        /// <summary>
        /// 公告类型
        /// </summary>
        [XmlElement("proclamation_type")]
        public string ProclamationType { get; set; }
    }
}
