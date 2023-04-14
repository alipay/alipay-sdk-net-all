using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceSportsVunueOrdervoucherVerifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceSportsVunueOrdervoucherVerifyModel : AopObject
    {
        /// <summary>
        /// 核销描述
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 支付宝业务订单唯一ID
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 服务商内部唯一订单号
        /// </summary>
        [XmlElement("out_order_id")]
        public string OutOrderId { get; set; }

        /// <summary>
        /// 服务商提供的外部凭证ID
        /// </summary>
        [XmlElement("out_voucher_id")]
        public string OutVoucherId { get; set; }

        /// <summary>
        /// 剩余核销次数
        /// </summary>
        [XmlElement("verify_count")]
        public string VerifyCount { get; set; }

        /// <summary>
        /// 核销状态，1-未核销，2-核销完成
        /// </summary>
        [XmlElement("verify_status")]
        public string VerifyStatus { get; set; }
    }
}
