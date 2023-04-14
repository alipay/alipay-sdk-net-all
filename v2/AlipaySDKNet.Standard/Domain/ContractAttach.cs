using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ContractAttach Data Structure.
    /// </summary>
    [Serializable]
    public class ContractAttach : AopObject
    {
        /// <summary>
        /// 合同附件业务状态 申请用印时传递 已定稿 CREATED 已创建 CONFIRMED 已定稿 DELETE 已删除
        /// </summary>
        [XmlElement("biz_status")]
        public string BizStatus { get; set; }

        /// <summary>
        /// 文件地址(调用合同中心提供的文件上传时返回的filekey)
        /// </summary>
        [XmlElement("file_location")]
        public string FileLocation { get; set; }

        /// <summary>
        /// 文件名称
        /// </summary>
        [XmlElement("file_name")]
        public string FileName { get; set; }

        /// <summary>
        /// 文件类型 DOC 正文 ATTACH 附件
        /// </summary>
        [XmlElement("file_type")]
        public string FileType { get; set; }

        /// <summary>
        /// 文件路径（HTTP下载链接）
        /// </summary>
        [XmlElement("file_url")]
        public string FileUrl { get; set; }

        /// <summary>
        /// 是否为http方式下载文件
        /// </summary>
        [XmlElement("type_is_http")]
        public bool TypeIsHttp { get; set; }
    }
}
