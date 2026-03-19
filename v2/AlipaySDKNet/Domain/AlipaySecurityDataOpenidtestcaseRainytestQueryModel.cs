using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityDataOpenidtestcaseRainytestQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityDataOpenidtestcaseRainytestQueryModel : AopObject
    {
        /// <summary>
        /// demo
        /// </summary>
        [XmlElement("demo")]
        public string Demo { get; set; }

        /// <summary>
        /// 金额
        /// </summary>
        [XmlElement("demo_price")]
        public string DemoPrice { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// OPENid 相关的映射类型
        /// </summary>
        [XmlElement("openid_complex")]
        public RainyComplexTypesTheThird OpenidComplex { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
