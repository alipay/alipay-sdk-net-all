using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceYuntaskPointExchangeResponse.
    /// </summary>
    public class AlipayCommerceYuntaskPointExchangeResponse : AopResponse
    {
        /// <summary>
        /// 积分流水id
        /// </summary>
        [XmlElement("instruction_id")]
        public string InstructionId { get; set; }

        /// <summary>
        /// 结果信息
        /// </summary>
        [XmlElement("messsage")]
        public string Messsage { get; set; }

        /// <summary>
        /// 兑换积分数
        /// </summary>
        [XmlElement("point")]
        public string Point { get; set; }

        /// <summary>
        /// 处理结果
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
