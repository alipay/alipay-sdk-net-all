using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniQrcodePatternCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniQrcodePatternCreateModel : AopObject
    {
        /// <summary>
        /// 调用类型，目前支持三种调用类型：DELEGATE、MERCHANT和ISV，不同调用类型会导致模式归属者不同
        /// </summary>
        [XmlElement("invoke_type")]
        public string InvokeType { get; set; }

        /// <summary>
        /// 模式，用于描述通用的路由url格式，适用于同一个host下面存在大量路由的场景，主要用于提升路由性能，其中{0}、{1} 代表路径中的变量
        /// </summary>
        [XmlElement("pattern_url")]
        public string PatternUrl { get; set; }

        /// <summary>
        /// 模板小程序ID。当invoke_type为DELEGATE或者ISV时，需要指定模板小程序的ID，用于校验模式的host是否存在于该模板小程序普通链接二维码的已验证列表中；当invoke_type为MERCHANT时，需要确保模式host所在的域名服务器根目录下放置了校验文件
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }
    }
}
