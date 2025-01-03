using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// WatchPromoPrizeDetail Data Structure.
    /// </summary>
    [Serializable]
    public class WatchPromoPrizeDetail : AopObject
    {
        /// <summary>
        /// 发奖单号
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 跳转支付宝链接，领奖链接
        /// </summary>
        [XmlElement("jump_alipay_url")]
        public string JumpAlipayUrl { get; set; }

        /// <summary>
        /// CLAIMED-已领取，UNCLAIMED-待领取
        /// </summary>
        [XmlElement("prize_state")]
        public string PrizeState { get; set; }

        /// <summary>
        /// 奖品类型，RED_PACKET-红包，SKIN-皮肤
        /// </summary>
        [XmlElement("prize_type")]
        public string PrizeType { get; set; }

        /// <summary>
        /// 非必填(红包)/必填(皮肤)，皮肤id
        /// </summary>
        [XmlElement("skin_id")]
        public string SkinId { get; set; }
    }
}
