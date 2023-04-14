using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IndirectIsvTerminalInfo Data Structure.
    /// </summary>
    [Serializable]
    public class IndirectIsvTerminalInfo : AopObject
    {
        /// <summary>
        /// terminal_id+不唯一+间连服务商活动报名设备品牌+无枚举+外部传入+无特殊说明
        /// </summary>
        [XmlElement("terminal_brand")]
        public string TerminalBrand { get; set; }

        /// <summary>
        /// terminal_id+唯一+间连服务商活动报名设备id+无枚举+外部传入+无特殊说明
        /// </summary>
        [XmlElement("terminal_id")]
        public string TerminalId { get; set; }
    }
}
