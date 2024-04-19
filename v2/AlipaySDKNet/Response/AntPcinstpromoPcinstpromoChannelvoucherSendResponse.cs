using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntPcinstpromoPcinstpromoChannelvoucherSendResponse.
    /// </summary>
    public class AntPcinstpromoPcinstpromoChannelvoucherSendResponse : AopResponse
    {
        /// <summary>
        /// 接收渠道红包的，脱敏后的支付宝登录号
        /// </summary>
        [XmlElement("account_no")]
        public string AccountNo { get; set; }

        /// <summary>
        /// 活动id
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 活动流水唯一记录
        /// </summary>
        [XmlElement("activity_order_id")]
        public string ActivityOrderId { get; set; }

        /// <summary>
        /// 优惠门槛金额 比喻: A.满5元减3元，则值是500 B.满10元随机立减1元到3元,则值是1000 整数类型，以分为单位。
        /// </summary>
        [XmlElement("discount_threshold_amt")]
        public long DiscountThresholdAmt { get; set; }

        /// <summary>
        /// reduce:满立减(满5元减3元) random:随机立减(满10元随机立减1元到3元)
        /// </summary>
        [XmlElement("discount_type")]
        public string DiscountType { get; set; }

        /// <summary>
        /// 比喻: A.满5元减3元，则值是300(单位：分) B.满10元随机立减1元到3元,则值是具体的金额，如果随机1.5元，则值为150(单位:分)
        /// </summary>
        [XmlElement("discount_value")]
        public long DiscountValue { get; set; }

        /// <summary>
        /// 券发放金额，以分为单位，比喻599，代表5.99元的面额
        /// </summary>
        [XmlElement("send_amount")]
        public long SendAmount { get; set; }

        /// <summary>
        /// 发放流水状态
        /// </summary>
        [XmlElement("send_status")]
        public string SendStatus { get; set; }

        /// <summary>
        /// 券平台唯一id
        /// </summary>
        [XmlElement("voucher_id")]
        public string VoucherId { get; set; }
    }
}
