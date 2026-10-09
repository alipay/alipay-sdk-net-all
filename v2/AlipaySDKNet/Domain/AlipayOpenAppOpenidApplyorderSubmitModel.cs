using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppOpenidApplyorderSubmitModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppOpenidApplyorderSubmitModel : AopObject
    {
        /// <summary>
        /// 工单唯一标识
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }
    }
}
