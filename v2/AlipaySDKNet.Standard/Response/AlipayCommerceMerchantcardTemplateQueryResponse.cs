using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMerchantcardTemplateQueryResponse.
    /// </summary>
    public class AlipayCommerceMerchantcardTemplateQueryResponse : AopResponse
    {
        /// <summary>
        /// 商品信息
        /// </summary>
        [XmlElement("card_template")]
        public MerchantCardTemplate CardTemplate { get; set; }
    }
}
