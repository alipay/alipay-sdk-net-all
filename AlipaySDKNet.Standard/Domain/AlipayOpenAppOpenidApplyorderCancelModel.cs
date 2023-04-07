using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppOpenidApplyorderCancelModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppOpenidApplyorderCancelModel : AopObject
    {
        /// <summary>
        /// 工单唯一标识
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }
    }
}
