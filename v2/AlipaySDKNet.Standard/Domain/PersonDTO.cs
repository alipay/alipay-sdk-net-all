using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PersonDTO Data Structure.
    /// </summary>
    [Serializable]
    public class PersonDTO : AopObject
    {
        /// <summary>
        /// 是否离职
        /// </summary>
        [XmlElement("resign")]
        public bool Resign { get; set; }

        /// <summary>
        /// 员工名字
        /// </summary>
        [XmlElement("user_name")]
        public string UserName { get; set; }

        /// <summary>
        /// 员工工号
        /// </summary>
        [XmlElement("work_no")]
        public string WorkNo { get; set; }
    }
}
