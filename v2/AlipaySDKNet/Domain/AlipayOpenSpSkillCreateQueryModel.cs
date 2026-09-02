using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenSpSkillCreateQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenSpSkillCreateQueryModel : AopObject
    {
        /// <summary>
        /// 申请单号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }
    }
}
