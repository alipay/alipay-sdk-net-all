using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ChinaMobileVoucher Data Structure.
    /// </summary>
    [Serializable]
    public class ChinaMobileVoucher : AopObject
    {
        /// <summary>
        /// 支付宝券操作消息中的操作时间
        /// </summary>
        [XmlElement("biz_time")]
        public string BizTime { get; set; }

        /// <summary>
        /// 支付宝推送给聚积宝的券使用信息中的券操作状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 聚积宝收到的支付宝核销券信息的Id
        /// </summary>
        [XmlElement("voucher_id")]
        public string VoucherId { get; set; }
    }
}
