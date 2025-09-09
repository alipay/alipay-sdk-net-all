using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CardDiscountRecoverRule Data Structure.
    /// </summary>
    [Serializable]
    public class CardDiscountRecoverRule : AopObject
    {
        /// <summary>
        /// 用户使用满多少期后才允许用户主动解约，不传默认不允许用户主动解约
        /// </summary>
        [XmlElement("least_period")]
        public long LeastPeriod { get; set; }

        /// <summary>
        /// 配置了允许解约期数后，该字段控制用户发起解约后是否需要优惠追回
        /// </summary>
        [XmlElement("recover_rule")]
        public string RecoverRule { get; set; }
    }
}
