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
        /// 路由规则组，用于唯一标记一条路由规则。调用 https://opendocs.alipay.com/apis/00rkye 接口关联普通二维码后的返回值。
        /// </summary>
        [XmlElement("route_group")]
        public string RouteGroup { get; set; }
    }
}
