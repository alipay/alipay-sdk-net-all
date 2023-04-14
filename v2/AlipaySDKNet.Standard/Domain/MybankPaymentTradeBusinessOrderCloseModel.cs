using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MybankPaymentTradeBusinessOrderCloseModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankPaymentTradeBusinessOrderCloseModel : AopObject
    {
        /// <summary>
        /// 创建订单时返回的订单号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 订单创建的外部平台的单据号
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 网商用户信息ID，一般是银行卡或者会员ID
        /// </summary>
        [XmlElement("user_info_id")]
        public string UserInfoId { get; set; }

        /// <summary>
        /// 网商用户类型
        /// </summary>
        [XmlElement("user_info_type")]
        public string UserInfoType { get; set; }
    }
}
