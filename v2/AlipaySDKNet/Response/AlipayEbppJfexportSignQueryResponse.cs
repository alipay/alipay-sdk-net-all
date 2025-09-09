using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppJfexportSignQueryResponse.
    /// </summary>
    public class AlipayEbppJfexportSignQueryResponse : AopResponse
    {
        /// <summary>
        /// 资产id银行卡签约号
        /// </summary>
        [XmlElement("asset_id")]
        public string AssetId { get; set; }

        /// <summary>
        /// 卡类型，枚举值： EXPRESS_DC：储蓄卡 EXPRESS_CC：信用卡
        /// </summary>
        [XmlElement("assigned_channel")]
        public string AssignedChannel { get; set; }

        /// <summary>
        /// 银行id
        /// </summary>
        [XmlElement("bank_id")]
        public string BankId { get; set; }

        /// <summary>
        /// 支付渠道名称
        /// </summary>
        [XmlElement("channel_full_name")]
        public string ChannelFullName { get; set; }

        /// <summary>
        /// 户号是否当前用户签约
        /// </summary>
        [XmlElement("current_user_sign")]
        public bool CurrentUserSign { get; set; }

        /// <summary>
        /// 1表示协议正常，0表示协议不正常
        /// </summary>
        [XmlElement("status")]
        public long Status { get; set; }

        /// <summary>
        /// 户号是否被签约
        /// </summary>
        [XmlElement("user_direct_sign")]
        public bool UserDirectSign { get; set; }
    }
}
