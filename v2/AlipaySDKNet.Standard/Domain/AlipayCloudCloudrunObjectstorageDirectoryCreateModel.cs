using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudrunObjectstorageDirectoryCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudrunObjectstorageDirectoryCreateModel : AopObject
    {
        /// <summary>
        /// 定义文件的访问权限。
        /// </summary>
        [XmlElement("acl")]
        public string Acl { get; set; }

        /// <summary>
        /// 内部使用，uiam角色扮演token
        /// </summary>
        [XmlElement("assume_token")]
        public string AssumeToken { get; set; }

        /// <summary>
        /// 环境ID，唯一，开通小程序云系统会生成环境ID，请从开通页面获取
        /// </summary>
        [XmlElement("env")]
        public string Env { get; set; }

        /// <summary>
        /// 文件夹的绝对路径
        /// </summary>
        [XmlElement("path")]
        public string Path { get; set; }
    }
}
