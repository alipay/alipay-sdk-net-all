using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MpcOrderResult Data Structure.
    /// </summary>
    [Serializable]
    public class MpcOrderResult : AopObject
    {
        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("create_date")]
        public string CreateDate { get; set; }

        /// <summary>
        /// 物流状态
        /// </summary>
        [XmlElement("logistics_status")]
        public string LogisticsStatus { get; set; }

        /// <summary>
        /// 子订单数量
        /// </summary>
        [XmlElement("order_amount")]
        public long OrderAmount { get; set; }

        /// <summary>
        /// 订单编号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 子订单详情
        /// </summary>
        [XmlArray("order_line_list")]
        [XmlArrayItem("mpc_order_line_result")]
        public List<MpcOrderLineResult> OrderLineList { get; set; }

        /// <summary>
        /// 订单状态
        /// </summary>
        [XmlElement("order_status")]
        public string OrderStatus { get; set; }
    }
}
