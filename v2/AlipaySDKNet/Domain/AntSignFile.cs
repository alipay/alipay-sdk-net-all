using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntSignFile Data Structure.
    /// </summary>
    [Serializable]
    public class AntSignFile : AopObject
    {
        /// <summary>
        /// 内部TR接入传入：非蚂蚁内网域名，提前联系技术对接负责人添加域名白名单。与fileKey二选一，推荐接入oss，传递fileKey
        /// </summary>
        [XmlElement("file_http_url")]
        public string FileHttpUrl { get; set; }

        /// <summary>
        /// 单次请求文件唯一id，与CaSystemSignFileRequest中的fileId对应
        /// </summary>
        [XmlElement("file_id")]
        public string FileId { get; set; }

        /// <summary>
        /// 推荐使用目录：ESIGN/你的应用名/日期/随机数/你的文件名 例：ESIGN/cif/20230801/201212112/aa.pdf。保证每次请求的fileKey不同，不同请求用同一个fileKey存在文件覆盖问题！！！
        /// </summary>
        [XmlElement("file_key")]
        public string FileKey { get; set; }

        /// <summary>
        /// 文件名称
        /// </summary>
        [XmlElement("file_name")]
        public string FileName { get; set; }

        /// <summary>
        /// 文件类型
        /// </summary>
        [XmlElement("file_type")]
        public string FileType { get; set; }
    }
}
