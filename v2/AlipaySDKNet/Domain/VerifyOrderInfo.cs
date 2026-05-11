using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VerifyOrderInfo Data Structure.
    /// </summary>
    [Serializable]
    public class VerifyOrderInfo : AopObject
    {
        /// <summary>
        /// 用于标识是线上还是线下门店
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 用于标识终端所在系统
        /// </summary>
        [XmlElement("os_type")]
        public string OsType { get; set; }

        /// <summary>
        /// 用于表示发起方使用的终端类型
        /// </summary>
        [XmlElement("terminal_type")]
        public string TerminalType { get; set; }
    }
}
