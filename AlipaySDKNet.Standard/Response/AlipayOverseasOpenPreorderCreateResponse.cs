using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOverseasOpenPreorderCreateResponse.
    /// </summary>
    public class AlipayOverseasOpenPreorderCreateResponse : AopResponse
    {
        /// <summary>
        /// 预创建单单号
        /// </summary>
        [XmlElement("pre_order_id")]
        public string PreOrderId { get; set; }

        /// <summary>
        /// 结果
        /// </summary>
        [XmlElement("result")]
        public TuitionISVResult Result { get; set; }
    }
}
