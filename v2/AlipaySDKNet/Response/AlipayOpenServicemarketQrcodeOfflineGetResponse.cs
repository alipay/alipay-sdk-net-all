using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenServicemarketQrcodeOfflineGetResponse.
    /// </summary>
    public class AlipayOpenServicemarketQrcodeOfflineGetResponse : AopResponse
    {
        /// <summary>
        /// 服务logo，该字段是服务的logo，用于前端展示
        /// </summary>
        [XmlElement("logo")]
        public string Logo { get; set; }

        /// <summary>
        /// 生成二维码后的url，该字段是调用当前api生成返回的二维码的url，用于服务商线下推广使用
        /// </summary>
        [XmlElement("qr_code_url")]
        public string QrCodeUrl { get; set; }

        /// <summary>
        /// 副标题，该字段是当前服务的副标题，不一定有，用于前端展示
        /// </summary>
        [XmlElement("sub_title")]
        public string SubTitle { get; set; }

        /// <summary>
        /// 服务标题，该字段是当前服务的标题，用于前端展示
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 生成二维码前的url，该字段是将merchandise_id、ticket、callback、app_name这几个字段简单拼接后的url，用于服务商校验参数使用
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
