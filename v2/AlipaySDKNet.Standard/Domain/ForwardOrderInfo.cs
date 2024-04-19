using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ForwardOrderInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ForwardOrderInfo : AopObject
    {
        /// <summary>
        /// 问题描述
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 客权工单创建时间
        /// </summary>
        [XmlElement("order_create_time")]
        public string OrderCreateTime { get; set; }

        /// <summary>
        /// 工单类型：流程code
        /// </summary>
        [XmlElement("order_type")]
        public string OrderType { get; set; }

        /// <summary>
        /// 机构工单要求完结时间
        /// </summary>
        [XmlElement("out_order_expect_time")]
        public string OutOrderExpectTime { get; set; }

        /// <summary>
        /// 客权工单要求完结时间
        /// </summary>
        [XmlElement("self_order_expect_time")]
        public string SelfOrderExpectTime { get; set; }
    }
}
