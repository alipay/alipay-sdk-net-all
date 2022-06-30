using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// JointAccountBillDetailDTO Data Structure.
    /// </summary>
    [Serializable]
    public class JointAccountBillDetailDTO : AopObject
    {
        /// <summary>
        /// 共同账户ID
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 消费金额
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 账单业务号
        /// </summary>
        [XmlElement("bill_no")]
        public string BillNo { get; set; }

        /// <summary>
        /// 业务时间
        /// </summary>
        [XmlElement("biz_date")]
        public string BizDate { get; set; }

        /// <summary>
        /// 订单号
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 1-退款，2-支付
        /// </summary>
        [XmlElement("in_out")]
        public string InOut { get; set; }

        /// <summary>
        /// 账单标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 共同账户消费的成员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
