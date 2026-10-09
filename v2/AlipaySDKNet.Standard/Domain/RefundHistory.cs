using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RefundHistory Data Structure.
    /// </summary>
    [Serializable]
    public class RefundHistory : AopObject
    {
        /// <summary>
        /// 提现金额(分)
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 提现申请时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 提现完成时间
        /// </summary>
        [XmlElement("finish_time")]
        public string FinishTime { get; set; }

        /// <summary>
        /// 提现错误信息
        /// </summary>
        [XmlElement("message")]
        public string Message { get; set; }

        /// <summary>
        /// 提现单号
        /// </summary>
        [XmlElement("refund_order_no")]
        public string RefundOrderNo { get; set; }

        /// <summary>
        /// 提现状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
