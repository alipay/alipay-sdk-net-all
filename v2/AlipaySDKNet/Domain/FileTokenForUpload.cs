using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FileTokenForUpload Data Structure.
    /// </summary>
    [Serializable]
    public class FileTokenForUpload : AopObject
    {
        /// <summary>
        /// OSS授权的访问用户
        /// </summary>
        [XmlElement("access_id")]
        public string AccessId { get; set; }

        /// <summary>
        /// 授权使用的目录
        /// </summary>
        [XmlElement("dir")]
        public string Dir { get; set; }

        /// <summary>
        /// 有效时间
        /// </summary>
        [XmlElement("expire")]
        public string Expire { get; set; }

        /// <summary>
        /// 上传OSS的host地址
        /// </summary>
        [XmlElement("host")]
        public string Host { get; set; }

        /// <summary>
        /// 设置的使用策略
        /// </summary>
        [XmlElement("policy")]
        public string Policy { get; set; }

        /// <summary>
        /// 服务端签名
        /// </summary>
        [XmlElement("signature")]
        public string Signature { get; set; }
    }
}
