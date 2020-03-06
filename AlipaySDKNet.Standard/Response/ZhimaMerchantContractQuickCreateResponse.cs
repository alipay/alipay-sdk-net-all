using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaMerchantContractQuickCreateResponse.
    /// </summary>
    public class ZhimaMerchantContractQuickCreateResponse : AopResponse
    {
        /// <summary>
        /// 发约单单号
        /// </summary>
        [XmlElement("offer_no")]
        public string OfferNo { get; set; }
    }
}
