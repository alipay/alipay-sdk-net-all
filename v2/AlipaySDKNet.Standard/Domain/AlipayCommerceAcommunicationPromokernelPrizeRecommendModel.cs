using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceAcommunicationPromokernelPrizeRecommendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceAcommunicationPromokernelPrizeRecommendModel : AopObject
    {
        /// <summary>
        /// 用户唯一标识，可以通过端内的jsApi进行获取。其实就是2088开头的支付宝ID。
        /// </summary>
        [XmlElement("alipay_user_unique_identifier")]
        public string AlipayUserUniqueIdentifier { get; set; }

        /// <summary>
        /// 活动平台活动ID，活动唯一标记。
        /// </summary>
        [XmlElement("camp_id")]
        public string CampId { get; set; }

        /// <summary>
        /// 如果不填则使用随机生成uuid
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 奖品ID, 当需要指定奖品抽奖的时候传入。
        /// </summary>
        [XmlElement("prize_id")]
        public string PrizeId { get; set; }
    }
}
