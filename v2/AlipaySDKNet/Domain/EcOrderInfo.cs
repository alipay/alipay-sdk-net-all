using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EcOrderInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EcOrderInfo : AopObject
    {
        /// <summary>
        /// 父订单详情
        /// </summary>
        [XmlElement("order_info")]
        public EcOrderItem OrderInfo { get; set; }

        /// <summary>
        /// 子订单详情列表
        /// </summary>
        [XmlArray("sub_order_list")]
        [XmlArrayItem("ec_order_item")]
        public List<EcOrderItem> SubOrderList { get; set; }
    }
}
