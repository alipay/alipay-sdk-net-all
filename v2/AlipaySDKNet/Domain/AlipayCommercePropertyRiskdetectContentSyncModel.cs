using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommercePropertyRiskdetectContentSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommercePropertyRiskdetectContentSyncModel : AopObject
    {
        /// <summary>
        /// createTime 内容物抓取时间,格式 yyyy-mm-dd hh:mm:ss
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 支付宝侧设备id。说明： deviceId、outDeviceId至少传其中之一
        /// </summary>
        [XmlElement("device_id")]
        public string DeviceId { get; set; }

        /// <summary>
        /// 从文件上传接口回参获取 ● uploadModel=OSS时 不可为空
        /// </summary>
        [XmlElement("file_key")]
        public string FileKey { get; set; }

        /// <summary>
        /// 需要上传的文件url,文件url的域名需要提前加白 ● uploadModel=URL时 不可为空
        /// </summary>
        [XmlElement("file_url")]
        public string FileUrl { get; set; }

        /// <summary>
        /// 机构侧标识内容的唯一ID
        /// </summary>
        [XmlElement("out_content_id")]
        public string OutContentId { get; set; }

        /// <summary>
        /// 外部设备编码。说明： deviceId、outDeviceId至少传其中之一
        /// </summary>
        [XmlElement("out_device_id")]
        public string OutDeviceId { get; set; }

        /// <summary>
        /// 上传模式 OSS ： 主动上传模式 URL： 公网URL转存模式  
        /// </summary>
        [XmlElement("upload_mode")]
        public string UploadMode { get; set; }
    }
}
