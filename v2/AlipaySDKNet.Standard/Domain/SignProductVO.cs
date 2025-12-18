using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SignProductVO Data Structure.
    /// </summary>
    [Serializable]
    public class SignProductVO : AopObject
    {
        /// <summary>
        /// 签约产品类型
        /// </summary>
        [XmlElement("product_type")]
        public string ProductType { get; set; }

        /// <summary>
        /// 付款签约和保险产品的签约链接
        /// </summary>
        [XmlElement("sign_url")]
        public string SignUrl { get; set; }
    }
}
