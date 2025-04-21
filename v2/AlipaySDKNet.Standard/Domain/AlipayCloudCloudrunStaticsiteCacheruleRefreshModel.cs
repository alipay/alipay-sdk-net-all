using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudrunStaticsiteCacheruleRefreshModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudrunStaticsiteCacheruleRefreshModel : AopObject
    {
        /// <summary>
        /// 内部使用，uiam角色扮演token
        /// </summary>
        [XmlElement("assume_token")]
        public string AssumeToken { get; set; }

        /// <summary>
        /// 文件/目录路径
        /// </summary>
        [XmlElement("data")]
        public string Data { get; set; }

        /// <summary>
        /// 环境ID
        /// </summary>
        [XmlElement("env")]
        public string Env { get; set; }

        /// <summary>
        /// 用户使用的app id，可以从小程序云用户中心获取
        /// </summary>
        [XmlElement("id_app")]
        public string IdApp { get; set; }

        /// <summary>
        /// 目前只支持两种File/Directory
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
