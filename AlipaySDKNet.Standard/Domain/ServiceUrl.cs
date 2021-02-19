using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ServiceUrl Data Structure.
    /// </summary>
    [Serializable]
    public class ServiceUrl : AopObject
    {
        /// <summary>
        /// 类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 链接 示例： alipays://platformapi/startapp?appId=2018052160106010&chInfo=ch_zhima&query=channelName%3Dmini_ji;（支付宝小程序地址）; amapuri://applets/platformapi/startapp?appId=2019021863152020&&page=pages/home2311;(高德小程序地址); uclink://www.uc.cn/cc77796ca7c25dff9607d31b29effc07?action=tinyapp&appid=2017071307737205&page=pages/home/test;(UC小程序地址); qklink://www.quark.cn/b20b84fd735a8dd3f7541129bacc4e9a?action=tinyapp&appId=2017071307737205&page=pages/home/test;(夸克小程序地址)
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
