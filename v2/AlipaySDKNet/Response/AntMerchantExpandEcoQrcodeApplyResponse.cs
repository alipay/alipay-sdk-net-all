using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntMerchantExpandEcoQrcodeApplyResponse.
    /// </summary>
    public class AntMerchantExpandEcoQrcodeApplyResponse : AopResponse
    {
        /// <summary>
        /// 用于生态发的空码，码信息详情
        /// </summary>
        [XmlElement("qrcode_info")]
        public AssetEcoQrcodeInfo QrcodeInfo { get; set; }
    }
}
