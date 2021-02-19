using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceOperationIsvQrcodeBindModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceOperationIsvQrcodeBindModel : AopObject
    {
        /// <summary>
        /// 业务场景
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 业务扩展参数
        /// </summary>
        [XmlElement("business_params")]
        public QrCodeBusinessParam BusinessParams { get; set; }

        /// <summary>
        /// 小程序类型
        /// </summary>
        [XmlElement("mini_type")]
        public string MiniType { get; set; }

        /// <summary>
        /// 目标跳转页面
        /// </summary>
        [XmlElement("page")]
        public string Page { get; set; }

        /// <summary>
        /// 微信公众号二维码码
        /// </summary>
        [XmlElement("qrcode_url")]
        public string QrcodeUrl { get; set; }
    }
}
