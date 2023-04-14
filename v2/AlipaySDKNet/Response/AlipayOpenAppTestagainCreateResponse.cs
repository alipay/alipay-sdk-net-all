using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenAppTestagainCreateResponse.
    /// </summary>
    public class AlipayOpenAppTestagainCreateResponse : AopResponse
    {
        /// <summary>
        /// xxxx
        /// </summary>
        [XmlElement("buyer_id")]
        public string BuyerId { get; set; }

        /// <summary>
        /// xxxx
        /// </summary>
        [XmlElement("buyer_openid")]
        public string BuyerOpenid { get; set; }

        /// <summary>
        /// 纬度
        /// </summary>
        [XmlElement("test")]
        public string Test { get; set; }

        /// <summary>
        /// sasasa
        /// </summary>
        [XmlElement("test_openid")]
        public string TestOpenid { get; set; }

        /// <summary>
        /// 1313
        /// </summary>
        [XmlElement("xxxxxx")]
        public string Xxxxxx { get; set; }
    }
}
