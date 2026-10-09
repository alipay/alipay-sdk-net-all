using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DspAppDownload Data Structure.
    /// </summary>
    [Serializable]
    public class DspAppDownload : AopObject
    {
        /// <summary>
        /// 应用下载扩展
        /// </summary>
        [XmlArray("app_download_ext_info")]
        [XmlArrayItem("dsp_app_download_ext_info")]
        public List<DspAppDownloadExtInfo> AppDownloadExtInfo { get; set; }

        /// <summary>
        /// 应用版本号
        /// </summary>
        [XmlElement("app_version")]
        public string AppVersion { get; set; }

        /// <summary>
        /// 下载地址
        /// </summary>
        [XmlElement("download_url")]
        public string DownloadUrl { get; set; }

        /// <summary>
        /// 应用包名
        /// </summary>
        [XmlElement("package_name")]
        public string PackageName { get; set; }

        /// <summary>
        /// 操作系统
        /// </summary>
        [XmlElement("platform")]
        public string Platform { get; set; }
    }
}
