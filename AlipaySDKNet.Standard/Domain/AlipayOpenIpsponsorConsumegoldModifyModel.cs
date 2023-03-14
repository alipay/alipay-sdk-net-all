using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenIpsponsorConsumegoldModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenIpsponsorConsumegoldModifyModel : AopObject
    {
        /// <summary>
        /// 蚂蚁统一会员OPEN ID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 用于标识具体扣、增消费金的值
        /// </summary>
        [XmlElement("scene_id")]
        public string SceneId { get; set; }

        /// <summary>
        /// 支付宝交易单号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
