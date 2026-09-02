using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenSpSkillCreateResponse.
    /// </summary>
    public class AlipayOpenSpSkillCreateResponse : AopResponse
    {
        /// <summary>
        /// 申请单号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }
    }
}
