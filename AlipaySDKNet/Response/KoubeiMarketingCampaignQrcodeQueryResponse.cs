using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiMarketingCampaignQrcodeQueryResponse.
    /// </summary>
    public class KoubeiMarketingCampaignQrcodeQueryResponse : AopResponse
    {
        /// <summary>
        /// 二维码地址，可以根据这个地址生成二维码
        /// </summary>
        [XmlElement("qrcode_url")]
        public string QrcodeUrl { get; set; }
    }
}
