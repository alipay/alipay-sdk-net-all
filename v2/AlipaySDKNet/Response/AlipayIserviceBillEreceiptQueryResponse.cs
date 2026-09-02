using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayIserviceBillEreceiptQueryResponse.
    /// </summary>
    public class AlipayIserviceBillEreceiptQueryResponse : AopResponse
    {
        /// <summary>
        /// PDF下载链接。当 status=SUCCESS 时返回，链接含电子章，可直接下载。链接有效期为20s，过期需重新申请。
        /// </summary>
        [XmlElement("download_url")]
        public string DownloadUrl { get; set; }

        /// <summary>
        /// 参数校验失败，fileId为空
        /// </summary>
        [XmlElement("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 回单生成失败
        /// </summary>
        [XmlElement("error_msg")]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 回单文件ID，与请求参数相同。
        /// </summary>
        [XmlElement("file_id")]
        public string FileId { get; set; }

        /// <summary>
        /// 回单状态。INIT/PROCESSING/SUCCESS/FAIL
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
