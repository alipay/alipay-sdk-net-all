using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppMerchantMeterialUploadResponse.
    /// </summary>
    public class AlipayEbppMerchantMeterialUploadResponse : AopResponse
    {
        /// <summary>
        /// 文件对应的MD5值, 用于文件完整性校验
        /// </summary>
        [XmlElement("md_5")]
        public string Md5 { get; set; }
    }
}
