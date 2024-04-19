using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// HelloBikePriceResultItem Data Structure.
    /// </summary>
    [Serializable]
    public class HelloBikePriceResultItem : AopObject
    {
        /// <summary>
        /// 优惠卡类型，枚举值为 mcard,qcard,hycard,ycard,tcard
        /// </summary>
        [XmlElement("card_type")]
        public string CardType { get; set; }

        /// <summary>
        /// 排序优先级,数字越小,优先级越高,没有经过排序的卡类型默认返回-1
        /// </summary>
        [XmlElement("priority")]
        public string Priority { get; set; }

        /// <summary>
        /// 推荐价格，单位为分
        /// </summary>
        [XmlElement("promo_price_cent")]
        public long PromoPriceCent { get; set; }
    }
}
