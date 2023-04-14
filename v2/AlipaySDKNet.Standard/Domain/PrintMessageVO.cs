using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PrintMessageVO Data Structure.
    /// </summary>
    [Serializable]
    public class PrintMessageVO : AopObject
    {
        /// <summary>
        /// 打印指令类型
        /// </summary>
        [XmlElement("cmd_type")]
        public string CmdType { get; set; }

        /// <summary>
        /// 打印指令内容
        /// </summary>
        [XmlElement("cmds")]
        public string Cmds { get; set; }
    }
}
