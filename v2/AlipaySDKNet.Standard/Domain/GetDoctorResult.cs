using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GetDoctorResult Data Structure.
    /// </summary>
    [Serializable]
    public class GetDoctorResult : AopObject
    {
        /// <summary>
        /// 所属科室
        /// </summary>
        [XmlElement("department")]
        public string Department { get; set; }

        /// <summary>
        /// 医生描述
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 头像
        /// </summary>
        [XmlElement("head")]
        public string Head { get; set; }

        /// <summary>
        /// 医院
        /// </summary>
        [XmlElement("hospital")]
        public string Hospital { get; set; }

        /// <summary>
        /// 医生名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 医生出诊时间
        /// </summary>
        [XmlElement("schedule")]
        public string Schedule { get; set; }

        /// <summary>
        /// 医生职称
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
