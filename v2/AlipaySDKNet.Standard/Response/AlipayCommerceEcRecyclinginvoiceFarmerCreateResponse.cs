using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcRecyclinginvoiceFarmerCreateResponse.
    /// </summary>
    public class AlipayCommerceEcRecyclinginvoiceFarmerCreateResponse : AopResponse
    {
        /// <summary>
        /// 农户授权链接
        /// </summary>
        [XmlElement("farmer_auth_url")]
        public string FarmerAuthUrl { get; set; }

        /// <summary>
        /// 农户ID
        /// </summary>
        [XmlElement("farmer_id")]
        public string FarmerId { get; set; }
    }
}
