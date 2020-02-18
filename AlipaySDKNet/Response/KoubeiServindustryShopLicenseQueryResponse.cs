using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiServindustryShopLicenseQueryResponse.
    /// </summary>
    public class KoubeiServindustryShopLicenseQueryResponse : AopResponse
    {
        /// <summary>
        /// 有一家shop有营业执照：true  所有shop无营业执照：false
        /// </summary>
        [XmlElement("have_permit")]
        public bool HavePermit { get; set; }
    }
}
