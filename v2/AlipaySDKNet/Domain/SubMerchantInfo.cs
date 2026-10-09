using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SubMerchantInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SubMerchantInfo : AopObject
    {
        /// <summary>
        /// 二级商户进件的smid信息,取自支付宝开放平台进件中的二级商户对应信息
        /// </summary>
        [XmlElement("merchant_id")]
        public string MerchantId { get; set; }
    }
}
