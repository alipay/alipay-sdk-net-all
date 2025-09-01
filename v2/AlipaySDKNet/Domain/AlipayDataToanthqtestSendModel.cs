using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataToanthqtestSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataToanthqtestSendModel : AopObject
    {
        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 测试
        /// </summary>
        [XmlElement("test")]
        public string Test { get; set; }

        /// <summary>
        /// 测试复杂类型
        /// </summary>
        [XmlArray("test_complex")]
        [XmlArrayItem("test_hq")]
        public List<TestHq> TestComplex { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
