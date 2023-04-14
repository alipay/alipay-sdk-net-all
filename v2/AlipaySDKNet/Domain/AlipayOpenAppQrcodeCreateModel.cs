using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppQrcodeCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppQrcodeCreateModel : AopObject
    {
        /// <summary>
        /// 圆形二维码颜色（十六进制颜色色值），仅圆形二维码支持颜色设置，方形二维码默认为黑色。
        /// </summary>
        [XmlElement("color")]
        public string Color { get; set; }

        /// <summary>
        /// 对应的二维码描述
        /// </summary>
        [XmlElement("describe")]
        public string Describe { get; set; }

        /// <summary>
        /// 小程序的启动参数，打开小程序的query ，在小程序 onLaunch的方法中获取。可查看 <a href= "https://opendocs.alipay.com/support/01rb2a">如何获取各种场景的启动参数</a>。
        /// </summary>
        [XmlElement("query_param")]
        public string QueryParam { get; set; }

        /// <summary>
        /// 合成后图片的大小 (s  -- 8cm, m -- 12cm, l -- 30cm)
        /// </summary>
        [XmlElement("size")]
        public string Size { get; set; }

        /// <summary>
        /// page/component/component-pages/view/view为小程序中能访问到的页面路径
        /// </summary>
        [XmlElement("url_param")]
        public string UrlParam { get; set; }
    }
}
