using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TerminalInfo Data Structure.
    /// </summary>
    [Serializable]
    public class TerminalInfo : AopObject
    {
        /// <summary>
        /// 自提时间说明
        /// </summary>
        [XmlElement("pickup_time_desc")]
        public string PickupTimeDesc { get; set; }

        /// <summary>
        /// 航站楼编码
        /// </summary>
        [XmlElement("terminal_code")]
        public string TerminalCode { get; set; }

        /// <summary>
        /// 航站楼名称
        /// </summary>
        [XmlElement("terminal_name")]
        public string TerminalName { get; set; }
    }
}
