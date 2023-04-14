using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CreateExtInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CreateExtInfo : AopObject
    {
        /// <summary>
        /// 信用等级无授权场景
        /// </summary>
        [XmlElement("cr_no_auth")]
        public CreditRateNoAuth CrNoAuth { get; set; }

        /// <summary>
        /// 信用等级部分授权场景
        /// </summary>
        [XmlElement("cr_partial_auth")]
        public CreditRatePartialAuth CrPartialAuth { get; set; }
    }
}
