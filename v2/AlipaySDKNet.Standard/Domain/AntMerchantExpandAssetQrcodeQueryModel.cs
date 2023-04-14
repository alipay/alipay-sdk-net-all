using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntMerchantExpandAssetQrcodeQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandAssetQrcodeQueryModel : AopObject
    {
        /// <summary>
        /// 二维码编码
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }
    }
}
