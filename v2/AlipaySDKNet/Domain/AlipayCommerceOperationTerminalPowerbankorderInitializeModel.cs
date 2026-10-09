using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceOperationTerminalPowerbankorderInitializeModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceOperationTerminalPowerbankorderInitializeModel : AopObject
    {
        /// <summary>
        /// 预授权单号，通过线上资金授权冻结接口获取
        /// </summary>
        [XmlElement("auth_id")]
        public string AuthId { get; set; }

        /// <summary>
        /// OpenId是用户（user_id）在应用（AppId）下的唯一用户标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 外部订单编号，唯一标识一个商户预授权订单，商户维度下外部订单号唯一。
        /// </summary>
        [XmlElement("out_trade_id")]
        public string OutTradeId { get; set; }

        /// <summary>
        /// 商户设备sn。设备必须已经完成进件，上报未进件设备的订单接口会报错
        /// </summary>
        [XmlElement("sn")]
        public string Sn { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
