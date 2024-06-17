using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OperaPersonVO Data Structure.
    /// </summary>
    [Serializable]
    public class OperaPersonVO : AopObject
    {
        /// <summary>
        /// 员工姓名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 员工花名
        /// </summary>
        [XmlElement("nick_name")]
        public string NickName { get; set; }

        /// <summary>
        /// 员工编号
        /// </summary>
        [XmlElement("worker_no")]
        public string WorkerNo { get; set; }
    }
}
