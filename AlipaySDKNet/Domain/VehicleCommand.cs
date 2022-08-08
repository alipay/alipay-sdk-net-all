using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VehicleCommand Data Structure.
    /// </summary>
    [Serializable]
    public class VehicleCommand : AopObject
    {
        /// <summary>
        /// 指令描述
        /// </summary>
        [XmlElement("command_desc")]
        public string CommandDesc { get; set; }

        /// <summary>
        /// 成功
        /// </summary>
        [XmlElement("command_result")]
        public string CommandResult { get; set; }

        /// <summary>
        /// 指令流水号
        /// </summary>
        [XmlElement("command_seq_no")]
        public string CommandSeqNo { get; set; }

        /// <summary>
        /// 指令时间戳
        /// </summary>
        [XmlElement("command_timestamp")]
        public string CommandTimestamp { get; set; }

        /// <summary>
        /// 指令类型
        /// </summary>
        [XmlElement("command_type")]
        public string CommandType { get; set; }

        /// <summary>
        /// 指令值 如是调节温度则是具体的温度值
        /// </summary>
        [XmlElement("command_value")]
        public string CommandValue { get; set; }
    }
}
