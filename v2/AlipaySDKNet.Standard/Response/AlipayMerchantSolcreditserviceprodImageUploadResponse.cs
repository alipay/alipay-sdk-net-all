using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantSolcreditserviceprodImageUploadResponse.
    /// </summary>
    public class AlipayMerchantSolcreditserviceprodImageUploadResponse : AopResponse
    {
        /// <summary>
        /// 链接地址
        /// </summary>
        [XmlElement("image_url")]
        public string ImageUrl { get; set; }
    }
}
