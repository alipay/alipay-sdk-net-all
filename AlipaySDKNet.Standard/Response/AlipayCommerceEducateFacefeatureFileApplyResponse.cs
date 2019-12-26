using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEducateFacefeatureFileApplyResponse.
    /// </summary>
    public class AlipayCommerceEducateFacefeatureFileApplyResponse : AopResponse
    {
        /// <summary>
        /// 文件下载url
        /// </summary>
        [XmlElement("download_url")]
        public string DownloadUrl { get; set; }

        /// <summary>
        /// 文件日期
        /// </summary>
        [XmlElement("file_date")]
        public string FileDate { get; set; }

        /// <summary>
        /// 机构ID+ISV名称+BIZ_CODE+日期+特征版本
        /// </summary>
        [XmlElement("file_name")]
        public string FileName { get; set; }

        /// <summary>
        /// 文件生成状态
        /// </summary>
        [XmlElement("file_status")]
        public string FileStatus { get; set; }
    }
}
