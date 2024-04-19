using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudrunObjectstorageObjectaclModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudrunObjectstorageObjectaclModifyModel : AopObject
    {
        /// <summary>
        /// 文件acl，取值default：默认，acl继承自桶的acl；private: 私有，公网无法直接访问获取；public-read: 公开，公网可以直接访问获取
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
        /// 文件ID(唯一)，文件的唯一索引ID，上传文件后系统会创建返回该文件的文件ID
        /// </summary>
        [XmlElement("file_id")]
        public string FileId { get; set; }
    }
}
