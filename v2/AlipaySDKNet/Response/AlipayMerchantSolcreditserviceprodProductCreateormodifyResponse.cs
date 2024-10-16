using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantSolcreditserviceprodProductCreateormodifyResponse.
    /// </summary>
    public class AlipayMerchantSolcreditserviceprodProductCreateormodifyResponse : AopResponse
    {
        /// <summary>
        /// 系统生成的商品编号
        /// </summary>
        [XmlElement("product_no")]
        public string ProductNo { get; set; }
    }
}
