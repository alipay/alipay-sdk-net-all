using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataexchangeTreeapitestRainystestQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataexchangeTreeapitestRainystestQueryModel : AopObject
    {
        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("demo")]
        public string Demo { get; set; }

        /// <summary>
        /// 支付宝用户的userId。 当前字段已废弃(可选参数，废弃原因测试)
        /// </summary>
        [XmlElement("demo_choice")]
        public string DemoChoice { get; set; }

        /// <summary>
        /// 支付宝用户的userId。 当前字段已废弃(特殊可选参数，废弃原因测试)
        /// </summary>
        [XmlElement("demo_sp")]
        public string DemoSp { get; set; }
    }
}
