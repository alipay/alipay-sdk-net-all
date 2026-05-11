using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingActivityOrdervoucherReceiveModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingActivityOrdervoucherReceiveModel : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("receive_info_list")]
        [XmlArrayItem("order_voucher_receive_info")]
        public List<OrderVoucherReceiveInfo> ReceiveInfoList { get; set; }

        /// <summary>
        /// 发券商户支付宝账号id
        /// </summary>
        [XmlElement("send_merchant_id")]
        public string SendMerchantId { get; set; }

        /// <summary>
        /// 发券商户支付宝账号id
        /// </summary>
        [XmlElement("send_merchant_open_id")]
        public string SendMerchantOpenId { get; set; }

        /// <summary>
        /// 领券用户支付宝id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 领券用户支付宝id
        /// </summary>
        [XmlElement("user_open_id")]
        public string UserOpenId { get; set; }
    }
}
