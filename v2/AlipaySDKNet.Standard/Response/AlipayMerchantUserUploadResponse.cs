using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantUserUploadResponse.
    /// </summary>
    public class AlipayMerchantUserUploadResponse : AopResponse
    {
        /// <summary>
        /// 上传批次号
        /// </summary>
        [XmlElement("batch_no")]
        public string BatchNo { get; set; }
    }
}
