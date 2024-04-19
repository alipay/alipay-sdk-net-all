using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniBrandBundleQueryResponse.
    /// </summary>
    public class AlipayOpenMiniBrandBundleQueryResponse : AopResponse
    {
        /// <summary>
        /// 是否经过品牌认证
        /// </summary>
        [XmlElement("brand_certified")]
        public bool BrandCertified { get; set; }

        /// <summary>
        /// 小程序品牌词
        /// </summary>
        [XmlElement("brand_word")]
        public string BrandWord { get; set; }
    }
}
