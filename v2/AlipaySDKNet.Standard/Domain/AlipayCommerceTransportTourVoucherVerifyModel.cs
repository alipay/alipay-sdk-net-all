using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportTourVoucherVerifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportTourVoucherVerifyModel : AopObject
    {
        /// <summary>
        /// 核销凭证的门店ID
        /// </summary>
        [XmlElement("ant_shop_id")]
        public string AntShopId { get; set; }

        /// <summary>
        /// 支付宝用户ID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 核销流水号,要求唯一
        /// </summary>
        [XmlElement("operate_serial_id")]
        public string OperateSerialId { get; set; }

        /// <summary>
        /// 实际的核销时间
        /// </summary>
        [XmlElement("operate_time")]
        public string OperateTime { get; set; }

        /// <summary>
        /// 支付宝订单号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 需要核销的商品凭证
        /// </summary>
        [XmlElement("voucher_verify_info")]
        public VoucherVerifyInfo VoucherVerifyInfo { get; set; }
    }
}
