using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntMerchantExpandStaticstockFileUploadResponse.
    /// </summary>
    public class AntMerchantExpandStaticstockFileUploadResponse : AopResponse
    {
        /// <summary>
        /// 上传结果
        /// </summary>
        [XmlElement("upload_result")]
        public AssetResult UploadResult { get; set; }
    }
}
