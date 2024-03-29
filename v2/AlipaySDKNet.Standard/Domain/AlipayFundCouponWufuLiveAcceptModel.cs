using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundCouponWufuLiveAcceptModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundCouponWufuLiveAcceptModel : AopObject
    {
        /// <summary>
        /// 发卡类型：WAN_NENG_FU-万能福，SURPRISE_CARD-惊喜福卡
        /// </summary>
        [XmlElement("card_type")]
        public string CardType { get; set; }

        /// <summary>
        /// 业务流水号
        /// </summary>
        [XmlElement("front_biz_no")]
        public string FrontBizNo { get; set; }

        /// <summary>
        /// 淘宝主播ID
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 淘宝用户ID
        /// </summary>
        [XmlElement("taobao_id")]
        public string TaobaoId { get; set; }
    }
}
