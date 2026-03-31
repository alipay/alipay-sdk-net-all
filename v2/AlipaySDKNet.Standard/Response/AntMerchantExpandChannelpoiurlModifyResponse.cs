using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntMerchantExpandChannelpoiurlModifyResponse.
    /// </summary>
    public class AntMerchantExpandChannelpoiurlModifyResponse : AopResponse
    {
        /// <summary>
        /// 小程序同步情况
        /// </summary>
        [XmlElement("progress")]
        public string Progress { get; set; }

        /// <summary>
        /// 小程序appId
        /// </summary>
        [XmlElement("shop_app_id")]
        public string ShopAppId { get; set; }
    }
}
