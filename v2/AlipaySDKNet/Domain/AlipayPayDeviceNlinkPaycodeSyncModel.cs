using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayPayDeviceNlinkPaycodeSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPayDeviceNlinkPaycodeSyncModel : AopObject
    {
        /// <summary>
        /// 用户的userId。
        /// </summary>
        [XmlElement("biz_user_id")]
        public string BizUserId { get; set; }

        /// <summary>
        /// 付款码创建时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 付款码过期时间
        /// </summary>
        [XmlElement("expire_time")]
        public string ExpireTime { get; set; }

        /// <summary>
        /// 碰一下的唯一标识，可用于串联每次用户碰的行为的所有业务链路
        /// </summary>
        [XmlElement("ntoken")]
        public string Ntoken { get; set; }

        /// <summary>
        /// 用户支付用到的码值，且商家可以用于创单的码值
        /// </summary>
        [XmlElement("paycode")]
        public string Paycode { get; set; }

        /// <summary>
        /// 是否可支付，PAYABLE/NOT_PAYABLE
        /// </summary>
        [XmlElement("paycode_status")]
        public string PaycodeStatus { get; set; }

        /// <summary>
        /// 用户支付的单号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
