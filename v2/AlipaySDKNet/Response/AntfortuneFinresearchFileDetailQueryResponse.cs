using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntfortuneFinresearchFileDetailQueryResponse.
    /// </summary>
    public class AntfortuneFinresearchFileDetailQueryResponse : AopResponse
    {
        /// <summary>
        /// 文件id
        /// </summary>
        [XmlElement("file_id")]
        public string FileId { get; set; }

        /// <summary>
        /// 文件名称
        /// </summary>
        [XmlElement("file_name")]
        public string FileName { get; set; }

        /// <summary>
        /// 文件的状态 果是上传过程需要轮询或获取结果，上传过程中如果结果为空，等待3s在重试，其余情况调用方根据自己的实际情况决定 从结果中的 upload_status 判断是否成功 FINISH 代表成功， ANALYZE_FAIL 代表上传失败， PARSING(文件解析中)、INIT(初始化，等待解析
        /// </summary>
        [XmlElement("upload_status")]
        public string UploadStatus { get; set; }
    }
}
