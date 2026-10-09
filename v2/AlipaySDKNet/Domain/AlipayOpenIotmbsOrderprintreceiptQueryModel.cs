using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenIotmbsOrderprintreceiptQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenIotmbsOrderprintreceiptQueryModel : AopObject
    {
        /// <summary>
        /// 订单中心产生的32位指令id
        /// </summary>
        [XmlElement("instruction_id")]
        public string InstructionId { get; set; }
    }
}
