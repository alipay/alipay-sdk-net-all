using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SaleControlDetail Data Structure.
    /// </summary>
    [Serializable]
    public class SaleControlDetail : AopObject
    {
        /// <summary>
        /// 售卖策略为SPEC_CROWD时传入该值，null标识无限制，枚举类型 1. STUDENT：学生 2. SILVER：银发人群（老人） 3. MEMBER：会员
        /// </summary>
        [XmlElement("crowd_type")]
        public string CrowdType { get; set; }

        /// <summary>
        /// 人数/年龄上限 售卖策略为PASSENGER_NUM/AGE时传入该值，null标识无限制
        /// </summary>
        [XmlElement("lower_limit")]
        public string LowerLimit { get; set; }

        /// <summary>
        /// 乘机人类型 售卖策略为PASSENGER_TYPE时传入该值，null标识无限制，枚举类型 ADULT：成人 ADULT_CHILD：成人+儿童 ADULT_INFANT：成人+婴儿
        /// </summary>
        [XmlElement("passenger_type")]
        public string PassengerType { get; set; }

        /// <summary>
        /// 人数/年龄上限 售卖策略为PASSENGER_NUM/AGE时传入该值，null标识无限制
        /// </summary>
        [XmlElement("up_limit")]
        public string UpLimit { get; set; }
    }
}
