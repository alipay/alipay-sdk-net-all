using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VoyagerEnvInfo Data Structure.
    /// </summary>
    [Serializable]
    public class VoyagerEnvInfo : AopObject
    {
        /// <summary>
        /// 客户端ip
        /// </summary>
        [XmlElement("client_ip")]
        public string ClientIp { get; set; }

        /// <summary>
        /// 系统类型
        /// </summary>
        [XmlElement("os_type")]
        public string OsType { get; set; }

        /// <summary>
        /// 终端类型，字段类型与请求参数保持一致
        /// </summary>
        [XmlElement("terminal_type")]
        public string TerminalType { get; set; }
    }
}
