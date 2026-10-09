using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppOpenidApplyorderCheckavailableModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppOpenidApplyorderCheckavailableModel : AopObject
    {
        /// <summary>
        /// 指定查询的工单，不填则查询最近的10条工单
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }
    }
}
