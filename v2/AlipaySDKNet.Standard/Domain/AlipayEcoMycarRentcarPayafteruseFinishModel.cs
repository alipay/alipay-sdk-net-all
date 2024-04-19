using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoMycarRentcarPayafteruseFinishModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarRentcarPayafteruseFinishModel : AopObject
    {
        /// <summary>
        /// 用户此订单是否守约。 传true时，用户在芝麻信用-守约记录中，该笔订单是已守约状态； 传false时，用户在芝麻信用-守约记录中，该笔订单是已取消状态。
        /// </summary>
        [XmlElement("is_fulfilled")]
        public bool IsFulfilled { get; set; }

        /// <summary>
        /// 支付宝用户开放平台id
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 支付宝用户id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
