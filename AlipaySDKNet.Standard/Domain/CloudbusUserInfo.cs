using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CloudbusUserInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CloudbusUserInfo : AopObject
    {
        /// <summary>
        /// 小孩
        /// </summary>
        [XmlElement("age_chrild")]
        public long AgeChrild { get; set; }

        /// <summary>
        /// 中年人
        /// </summary>
        [XmlElement("age_mider")]
        public long AgeMider { get; set; }

        /// <summary>
        /// 老年人
        /// </summary>
        [XmlElement("age_older")]
        public long AgeOlder { get; set; }

        /// <summary>
        /// 年前人
        /// </summary>
        [XmlElement("age_youth")]
        public long AgeYouth { get; set; }

        /// <summary>
        /// 男性人数
        /// </summary>
        [XmlElement("sex_man")]
        public long SexMan { get; set; }

        /// <summary>
        /// 女性人数
        /// </summary>
        [XmlElement("sex_woman")]
        public long SexWoman { get; set; }

        /// <summary>
        /// 上班族
        /// </summary>
        [XmlElement("w_officer")]
        public long WOfficer { get; set; }

        /// <summary>
        /// 非上班族
        /// </summary>
        [XmlElement("w_unofficer")]
        public long WUnofficer { get; set; }
    }
}
