using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAuthAppAesSetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAuthAppAesSetModel : AopObject
    {
        /// <summary>
        /// 商家应用appId
        /// </summary>
        [XmlElement("merchant_app_id")]
        public string MerchantAppId { get; set; }
    }
}
