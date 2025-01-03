using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenNppdUserpointRefundModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenNppdUserpointRefundModel : AopObject
    {
        /// <summary>
        /// 原始扣积分的请求ID
        /// </summary>
        [XmlElement("deducted_request_id")]
        public string DeductedRequestId { get; set; }

        /// <summary>
        /// 商品列表
        /// </summary>
        [XmlElement("item_list")]
        public string ItemList { get; set; }

        /// <summary>
        /// linkedmall订单号
        /// </summary>
        [XmlElement("lm_order_id")]
        public string LmOrderId { get; set; }

        /// <summary>
        /// 企业分配给阿里云的Code
        /// </summary>
        [XmlElement("merchant_code")]
        public string MerchantCode { get; set; }

        /// <summary>
        /// 企业提供的参数
        /// </summary>
        [XmlElement("merchant_exts")]
        public string MerchantExts { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 请求标识
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 企业侧的用户ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
