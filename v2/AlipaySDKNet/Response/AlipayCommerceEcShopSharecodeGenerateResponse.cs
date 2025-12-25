using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcShopSharecodeGenerateResponse.
    /// </summary>
    public class AlipayCommerceEcShopSharecodeGenerateResponse : AopResponse
    {
        /// <summary>
        /// 吱口令
        /// </summary>
        [XmlElement("share_code")]
        public string ShareCode { get; set; }
    }
}
