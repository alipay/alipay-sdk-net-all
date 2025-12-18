using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PBCHitDetail Data Structure.
    /// </summary>
    [Serializable]
    public class PBCHitDetail : AopObject
    {
        /// <summary>
        /// 名单匹配属性
        /// </summary>
        [XmlElement("match_param")]
        public string MatchParam { get; set; }

        /// <summary>
        /// 制裁扫描匹配参数
        /// </summary>
        [XmlElement("query_param")]
        public string QueryParam { get; set; }

        /// <summary>
        /// 名单中别名
        /// </summary>
        [XmlElement("record_aka")]
        public string RecordAka { get; set; }

        /// <summary>
        /// 生日
        /// </summary>
        [XmlElement("record_birth")]
        public string RecordBirth { get; set; }

        /// <summary>
        /// 名单中性别
        /// </summary>
        [XmlElement("record_gender")]
        public string RecordGender { get; set; }

        /// <summary>
        /// 名单中证件
        /// </summary>
        [XmlElement("record_id")]
        public string RecordId { get; set; }

        /// <summary>
        /// 名单中名称
        /// </summary>
        [XmlElement("record_name")]
        public string RecordName { get; set; }

        /// <summary>
        /// 名单中国籍
        /// </summary>
        [XmlElement("record_nation")]
        public string RecordNation { get; set; }

        /// <summary>
        /// 命中名单类型
        /// </summary>
        [XmlElement("record_type")]
        public string RecordType { get; set; }

        /// <summary>
        /// 名单原始id
        /// </summary>
        [XmlElement("reference_id")]
        public string ReferenceId { get; set; }
    }
}
