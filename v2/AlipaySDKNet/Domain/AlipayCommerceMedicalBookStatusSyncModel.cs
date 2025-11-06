using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalBookStatusSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalBookStatusSyncModel : AopObject
    {
        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 外部订单号
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 订单状态
        /// </summary>
        [XmlElement("status")]
        public long Status { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
