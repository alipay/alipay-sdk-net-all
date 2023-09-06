using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudrunObjectstorageUploadurlGetResponse.
    /// </summary>
    public class AlipayCloudCloudrunObjectstorageUploadurlGetResponse : AopResponse
    {
        /// <summary>
        /// 文件ID(唯一)，文件的唯一索引ID，上传文件后系统会创建返回该文件的文件ID
        /// </summary>
        [XmlElement("file_id")]
        public string FileId { get; set; }

        /// <summary>
        /// 仅当通过POST Form方式上传时有意义。 POST Form上传时，用户需要填写该接口返回的所有表单参数，且不能填写额外的表单参数，否则会上传失败。
        /// </summary>
        [XmlArray("form_data")]
        [XmlArrayItem("oss_post_upload_form_data")]
        public List<OssPostUploadFormData> FormData { get; set; }

        /// <summary>
        /// 文件上传地址，该文件的上传地址
        /// </summary>
        [XmlElement("upload_url")]
        public string UploadUrl { get; set; }
    }
}
