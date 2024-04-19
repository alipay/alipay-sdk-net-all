using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenServicemarketQrcodeOfflineGetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenServicemarketQrcodeOfflineGetModel : AopObject
    {
        /// <summary>
        /// 小程序名称，该字段非必传字段，用于表示此次参与交易的小程序具体是什么
        /// </summary>
        [XmlElement("app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// 商家回调地址，该字段是商家扫码后，跳转的地址url，比如商品详情页的url
        /// </summary>
        [XmlElement("callback")]
        public string Callback { get; set; }

        /// <summary>
        /// 服务id，该字段由调用方传入，是生成线下推广二维码的必要参数，该值是支付宝生成，可以在支付宝p站我的服务中查询对应的服务id
        /// </summary>
        [XmlElement("merchandise_id")]
        public string MerchandiseId { get; set; }

        /// <summary>
        /// 用于扩展信息，该值可以传入服务商想要扩展的信息，将会与其它参数一起存入码值信息中。
        /// </summary>
        [XmlElement("ticket")]
        public string Ticket { get; set; }
    }
}
