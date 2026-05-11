using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OrderElectronicReceipt Data Structure.
    /// </summary>
    [Serializable]
    public class OrderElectronicReceipt : AopObject
    {
        /// <summary>
        /// 下载链接。status为SUCCESS时返回。用户可以使用此http链接下载文件内容，电子回单文件为pdf格式。
        /// </summary>
        [XmlElement("download_url")]
        public string DownloadUrl { get; set; }

        /// <summary>
        /// 状态为FAILED，可联系业务人员处理
        /// </summary>
        [XmlElement("error_message")]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// 处理状态 INIT - 初始化 PROCESSING - 处理中 SUCCESS - 成功 FAILED - 失败
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
