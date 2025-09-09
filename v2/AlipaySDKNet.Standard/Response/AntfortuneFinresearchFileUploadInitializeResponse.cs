using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntfortuneFinresearchFileUploadInitializeResponse.
    /// </summary>
    public class AntfortuneFinresearchFileUploadInitializeResponse : AopResponse
    {
        /// <summary>
        /// 文件id
        /// </summary>
        [XmlElement("file_id")]
        public string FileId { get; set; }

        /// <summary>
        /// 接口请求是否成功
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
