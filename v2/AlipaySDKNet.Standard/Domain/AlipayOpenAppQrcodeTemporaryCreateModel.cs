using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppQrcodeTemporaryCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppQrcodeTemporaryCreateModel : AopObject
    {
        /// <summary>
        /// 圆形二维码颜色（十六进制颜色色值），仅圆形二维码支持颜色设置，方形二维码默认为黑色。
        /// </summary>
        [XmlElement("color")]
        public string Color { get; set; }

        /// <summary>
        /// 生成小程序动态码的类型
        /// </summary>
        [XmlElement("qrcode_type")]
        public string QrcodeType { get; set; }

        /// <summary>
        /// 小程序的启动参数，打开小程序的query ，在小程序 onLaunch的方法中获取。可查看 <a href= "https://opendocs.alipay.com/support/01rb2a">如何获取各种场景的启动参数</a>。
        /// </summary>
        [XmlElement("query_param")]
        public string QueryParam { get; set; }

        /// <summary>
        /// 单位秒，最长为2*60*60（2小时）
        /// </summary>
        [XmlElement("timeout")]
        public long Timeout { get; set; }

        /// <summary>
        /// page/component/component-pages/view/view为小程序中能访问到的页面路径
        /// </summary>
        [XmlElement("url_param")]
        public string UrlParam { get; set; }
    }
}
