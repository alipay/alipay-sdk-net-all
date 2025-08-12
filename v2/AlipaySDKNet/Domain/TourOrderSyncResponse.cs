using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TourOrderSyncResponse Data Structure.
    /// </summary>
    [Serializable]
    public class TourOrderSyncResponse : AopObject
    {
        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识。一码通场景必须保存
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 订单号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 凭证号
        /// </summary>
        [XmlElement("out_voucher_id")]
        public string OutVoucherId { get; set; }

        /// <summary>
        /// 支付宝用户的userId。 一码通场景必须保存
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 入库业务号。碰一下场景必须保存
        /// </summary>
        [XmlElement("vid")]
        public string Vid { get; set; }
    }
}
