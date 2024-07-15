using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataserviceDdQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceDdQueryModel : AopObject
    {
        /// <summary>
        /// 金额，单位元
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 测试
        /// </summary>
        [XmlElement("qwe")]
        public string Qwe { get; set; }

        /// <summary>
        /// 测试
        /// </summary>
        [XmlElement("test_openid")]
        public string TestOpenid { get; set; }

        /// <summary>
        /// 总金额 单位元
        /// </summary>
        [XmlElement("total")]
        public string Total { get; set; }

        /// <summary>
        /// 重量
        /// </summary>
        [XmlElement("weight")]
        public string Weight { get; set; }
    }
}
