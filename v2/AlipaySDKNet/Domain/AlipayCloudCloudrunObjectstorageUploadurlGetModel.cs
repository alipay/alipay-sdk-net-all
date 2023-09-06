using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudrunObjectstorageUploadurlGetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudrunObjectstorageUploadurlGetModel : AopObject
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
        /// 文件上传路径，请以"/"开头，此为期望在对象存储上保存的文件路径
        /// </summary>
        [XmlElement("path")]
        public string Path { get; set; }

        /// <summary>
        /// 上传文件要使用的方法，支持PUT/POST。 默认PUT，可选值：POST/PUT ● POST：通过POST Form的方式上传 ● PUT：通过PUT方法上传
        /// </summary>
        [XmlElement("upload_method")]
        public string UploadMethod { get; set; }
    }
}
