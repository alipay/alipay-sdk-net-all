using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayIserviceBillEreceiptApplyResponse.
    /// </summary>
    public class AlipayIserviceBillEreceiptApplyResponse : AopResponse
    {
        /// <summary>
        /// 错误码。
        /// </summary>
        [XmlElement("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 错误提示
        /// </summary>
        [XmlElement("error_msg")]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 回单文件ID。申请成功时返回，用于调用查询接口获取下载链接。
        /// </summary>
        [XmlElement("file_id")]
        public string FileId { get; set; }

        /// <summary>
        /// 回单申请状态。SUCCESS：申请成功；FAIL：申请失败。
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
