using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SceneRuleParams Data Structure.
    /// </summary>
    [Serializable]
    public class SceneRuleParams : AopObject
    {
        /// <summary>
        /// 在周期扣场景化模板中配置优惠类型为优惠期玩法时需要该参数，表示后续有多少期扣款可享受优惠，值为自然数代表周期
        /// </summary>
        [XmlElement("discount_period")]
        public string DiscountPeriod { get; set; }

        /// <summary>
        /// 在周期扣场景化模板中配置优惠类型为低价玩法时需要该参数，表示代扣低价期持续的时间。单位是天，该值为自然数
        /// </summary>
        [XmlElement("low_price_period")]
        public string LowPricePeriod { get; set; }
    }
}
