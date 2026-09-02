using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// XingheLendassistCarfinauctionApplyloanNotifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class XingheLendassistCarfinauctionApplyloanNotifyModel : AopObject
    {
        /// <summary>
        /// 星河申请单号
        /// </summary>
        [XmlElement("apply_no")]
        public string ApplyNo { get; set; }

        /// <summary>
        /// 尾款首付款支付证明文件id
        /// </summary>
        [XmlElement("file_id")]
        public string FileId { get; set; }

        /// <summary>
        /// 尾款首付款支付金额，单位为分
        /// </summary>
        [XmlElement("final_down_payment_amount")]
        public long FinalDownPaymentAmount { get; set; }

        /// <summary>
        /// 尾款首付款支付时间
        /// </summary>
        [XmlElement("final_down_payment_time")]
        public string FinalDownPaymentTime { get; set; }

        /// <summary>
        /// 外部订单号（阿里拍卖申请单号）
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }
    }
}
