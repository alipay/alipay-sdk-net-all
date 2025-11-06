using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenAppRentindustryItemUploadResponse.
    /// </summary>
    public class AlipayOpenAppRentindustryItemUploadResponse : AopResponse
    {
        /// <summary>
        /// 商品上传结果信息
        /// </summary>
        [XmlArray("upload_result")]
        [XmlArrayItem("merchant_sku_upload_result")]
        public List<MerchantSkuUploadResult> UploadResult { get; set; }
    }
}
