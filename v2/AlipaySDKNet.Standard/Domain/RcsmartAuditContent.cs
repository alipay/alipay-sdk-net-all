using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RcsmartAuditContent Data Structure.
    /// </summary>
    [Serializable]
    public class RcsmartAuditContent : AopObject
    {
        /// <summary>
        /// 素材业务类型，默认default。特殊场景需根据规则约定勿随意填写，随意填写会导致审核异常。
        /// </summary>
        [XmlElement("content_biz_type")]
        public string ContentBizType { get; set; }

        /// <summary>
        /// 素材内容（WORDS传入审核文字信息限制为10000个字节, PICTURE传外部url，图片文件建议不超过4M,单张传入图像最短边不少于15px,最长边不大于8192px，否则可能影响审核效果或造成审核异常） 若素材来源非蚂蚁域内可能受到域名访问限制，需要开通域名访问，仅支持域名不支持ip访问 大小校验
        /// </summary>
        [XmlElement("content_data")]
        public string ContentData { get; set; }

        /// <summary>
        /// 素材传输方式,枚举 目前支持 文字-WORDS/图片-PICTURE/音频-VOICE/文件-FILE
        /// </summary>
        [XmlElement("content_type")]
        public string ContentType { get; set; }

        /// <summary>
        /// 预留参数，K-V格式的string
        /// </summary>
        [XmlElement("ext_param")]
        public string ExtParam { get; set; }

        /// <summary>
        /// 文件接口返回的fileId，也就是oss的objectKey
        /// </summary>
        [XmlElement("file_id")]
        public string FileId { get; set; }

        /// <summary>
        /// 外部素材id,代表外部唯一素材
        /// </summary>
        [XmlElement("out_content_id")]
        public string OutContentId { get; set; }
    }
}
