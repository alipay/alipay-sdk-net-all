using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserKabaoVoucherModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserKabaoVoucherModifyModel : AopObject
    {
        /// <summary>
        /// 兑换券价值信息
        /// </summary>
        [XmlElement("exchange_voucher_value_info")]
        public ExchangeVoucherValueInfo ExchangeVoucherValueInfo { get; set; }

        /// <summary>
        /// 支付宝卡包优惠券的实例唯一id
        /// </summary>
        [XmlElement("instance_id")]
        public string InstanceId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 优惠券状态。
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
