using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudrunStaticsiteDirectoryCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudrunStaticsiteDirectoryCreateModel : AopObject
    {
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
        /// 文件夹绝对路径 ● 必须以"/"开头，不能以/结尾 ● 使用UTF-8编码 ● 长度必须在1024字符之间 ● 不能出现连续"/"
        /// </summary>
        [XmlElement("path")]
        public string Path { get; set; }
    }
}
