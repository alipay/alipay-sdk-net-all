using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ReassignNumberResult Data Structure.
    /// </summary>
    [Serializable]
    public class ReassignNumberResult : AopObject
    {
        /// <summary>
        /// 根据入参返回查询到的商户pid
        /// </summary>
        [XmlElement("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 是否疑似二次放号，true=疑似二次放号，false=非疑似
        /// </summary>
        [XmlElement("reassign_suspected")]
        public bool ReassignSuspected { get; set; }

        /// <summary>
        /// 非疑似时为空，疑似时二次放号的返回时间格式
        /// </summary>
        [XmlElement("reassign_time")]
        public string ReassignTime { get; set; }
    }
}
