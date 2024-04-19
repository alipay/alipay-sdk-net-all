using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// HSchoolInfo Data Structure.
    /// </summary>
    [Serializable]
    public class HSchoolInfo : AopObject
    {
        /// <summary>
        /// 学号
        /// </summary>
        [XmlElement("campus_no")]
        public string CampusNo { get; set; }

        /// <summary>
        /// 学校外标
        /// </summary>
        [XmlElement("school_std_code")]
        public string SchoolStdCode { get; set; }
    }
}
