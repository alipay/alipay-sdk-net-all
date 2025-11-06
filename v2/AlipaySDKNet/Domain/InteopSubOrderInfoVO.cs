using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InteopSubOrderInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class InteopSubOrderInfoVO : AopObject
    {
        /// <summary>
        /// 用于记录子单的原因信息
        /// </summary>
        [XmlElement("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// 一体化作业子单号
        /// </summary>
        [XmlElement("sub_order_no")]
        public string SubOrderNo { get; set; }

        /// <summary>
        /// 一体化作业子单桩体啊
        /// </summary>
        [XmlElement("sub_order_status")]
        public string SubOrderStatus { get; set; }

        /// <summary>
        /// 一体化作业子单类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
