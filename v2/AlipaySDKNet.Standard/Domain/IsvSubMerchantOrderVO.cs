using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IsvSubMerchantOrderVO Data Structure.
    /// </summary>
    [Serializable]
    public class IsvSubMerchantOrderVO : AopObject
    {
        /// <summary>
        /// 主申请单id
        /// </summary>
        [XmlElement("m_order_id")]
        public string MOrderId { get; set; }

        /// <summary>
        /// 子单状态
        /// </summary>
        [XmlElement("sub_order_status")]
        public string SubOrderStatus { get; set; }

        /// <summary>
        /// 子单类型
        /// </summary>
        [XmlElement("sub_order_type")]
        public string SubOrderType { get; set; }
    }
}
