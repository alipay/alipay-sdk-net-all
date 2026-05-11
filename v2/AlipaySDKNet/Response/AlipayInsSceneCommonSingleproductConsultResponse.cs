using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsSceneCommonSingleproductConsultResponse.
    /// </summary>
    public class AlipayInsSceneCommonSingleproductConsultResponse : AopResponse
    {
        /// <summary>
        /// 产品信息
        /// </summary>
        [XmlElement("product_info")]
        public ProductInfoDTO ProductInfo { get; set; }
    }
}
