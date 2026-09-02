using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// XingheLendassistCarfinauctionCloseNotifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class XingheLendassistCarfinauctionCloseNotifyModel : AopObject
    {
        /// <summary>
        /// 星河申请单号
        /// </summary>
        [XmlElement("apply_no")]
        public string ApplyNo { get; set; }

        /// <summary>
        /// 关闭原因描述
        /// </summary>
        [XmlElement("close_reason")]
        public string CloseReason { get; set; }

        /// <summary>
        /// 关闭时间
        /// </summary>
        [XmlElement("close_time")]
        public string CloseTime { get; set; }

        /// <summary>
        /// 关闭类型
        /// </summary>
        [XmlElement("close_type")]
        public string CloseType { get; set; }

        /// <summary>
        /// 外部订单号（阿里拍卖申请单号）
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }
    }
}
