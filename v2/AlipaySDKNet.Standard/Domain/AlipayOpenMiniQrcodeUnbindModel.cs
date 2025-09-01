using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniQrcodeUnbindModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniQrcodeUnbindModel : AopObject
    {
        /// <summary>
        /// 路由规则组，用于唯一标记一条路由规则。调用 <a href="https://opendocs.alipay.com/apis/00rkye" target="_blank">关联普通二维码</a> 接口关联普通二维码后的返回值。
        /// </summary>
        [XmlElement("route_group")]
        public string RouteGroup { get; set; }

        /// <summary>
        /// 路由规则URL，调用<a href="https://opendocs.alipay.com/apis/00rkye" target="_blank">关联普通二维码</a>接口传入的参数：route_url。解除模式与二维码的绑定关系需传入
        /// </summary>
        [XmlElement("route_url")]
        public string RouteUrl { get; set; }
    }
}
