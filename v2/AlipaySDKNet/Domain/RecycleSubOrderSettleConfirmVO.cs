using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecycleSubOrderSettleConfirmVO Data Structure.
    /// </summary>
    [Serializable]
    public class RecycleSubOrderSettleConfirmVO : AopObject
    {
        /// <summary>
        /// 回收的子单号
        /// </summary>
        [XmlElement("sub_order_id")]
        public string SubOrderId { get; set; }

        /// <summary>
        /// 商家的子单号
        /// </summary>
        [XmlElement("sub_out_order_id")]
        public string SubOutOrderId { get; set; }
    }
}
