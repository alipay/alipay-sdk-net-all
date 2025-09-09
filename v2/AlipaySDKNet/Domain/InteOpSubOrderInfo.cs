using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InteOpSubOrderInfo Data Structure.
    /// </summary>
    [Serializable]
    public class InteOpSubOrderInfo : AopObject
    {
        /// <summary>
        /// 备注
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 一体化作业子项单号
        /// </summary>
        [XmlElement("sub_order_no")]
        public string SubOrderNo { get; set; }

        /// <summary>
        /// 一体化作业子项状态
        /// </summary>
        [XmlElement("sub_order_status")]
        public string SubOrderStatus { get; set; }

        /// <summary>
        /// 一体化作业子项类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
