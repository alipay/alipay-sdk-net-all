using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportChargerCommandConfirmModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportChargerCommandConfirmModel : AopObject
    {
        /// <summary>
        /// 指令结果
        /// </summary>
        [XmlElement("command_result")]
        public string CommandResult { get; set; }

        /// <summary>
        /// 支付宝指令流水号，唯一
        /// </summary>
        [XmlElement("command_serial_number")]
        public string CommandSerialNumber { get; set; }
    }
}
