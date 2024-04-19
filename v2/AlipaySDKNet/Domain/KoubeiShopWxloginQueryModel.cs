using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiShopWxloginQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiShopWxloginQueryModel : AopObject
    {
        /// <summary>
        /// 业务类型，轻店业务传MERCHANT_APP
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 授权，固定值，传authorization_code
        /// </summary>
        [XmlElement("grant_type")]
        public string GrantType { get; set; }

        /// <summary>
        /// 前端页面获取的js_code
        /// </summary>
        [XmlElement("js_code")]
        public string JsCode { get; set; }

        /// <summary>
        /// 微信的app_id
        /// </summary>
        [XmlElement("wx_app_id")]
        public string WxAppId { get; set; }
    }
}
