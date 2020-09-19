using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SpecifyAttachmentInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SpecifyAttachmentInfo : AopObject
    {
        /// <summary>
        /// 是否允许上传更多附件，默认值为false。开启后，除了“collect_common_codes”中指定的附件，签署人可自由上传至多10张图片。
        /// </summary>
        [XmlElement("allow_more_uploads")]
        public bool AllowMoreUploads { get; set; }

        /// <summary>
        /// 允许上传更多附件时，可上传的最大附件数，一次流程中累计的上传附件数至多30（含“附件列表”数量）
        /// </summary>
        [XmlElement("allow_more_uploads_max_count")]
        public long AllowMoreUploadsMaxCount { get; set; }

        /// <summary>
        /// 需要签署人上传的证件照片，可进行ORC识别，目前仅支持IDCARD
        /// </summary>
        [XmlArray("collect_cert_types")]
        [XmlArrayItem("string")]
        public List<string> CollectCertTypes { get; set; }

        /// <summary>
        /// 需要签署人上传的其他附件列表，即attachment_explain.details中定义的code列表
        /// </summary>
        [XmlArray("collect_common_codes")]
        [XmlArrayItem("string")]
        public List<string> CollectCommonCodes { get; set; }

        /// <summary>
        /// 个人唯一标识，对应签署区中指定的签署人
        /// </summary>
        [XmlElement("third_party_user_id")]
        public string ThirdPartyUserId { get; set; }
    }
}
