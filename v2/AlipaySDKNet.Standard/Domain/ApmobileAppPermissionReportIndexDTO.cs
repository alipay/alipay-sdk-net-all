using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ApmobileAppPermissionReportIndexDTO Data Structure.
    /// </summary>
    [Serializable]
    public class ApmobileAppPermissionReportIndexDTO : AopObject
    {
        /// <summary>
        /// 版本号
        /// </summary>
        [XmlElement("app_version")]
        public string AppVersion { get; set; }

        /// <summary>
        /// 证书摘要
        /// </summary>
        [XmlElement("cert_md_5")]
        public string CertMd5 { get; set; }

        /// <summary>
        /// 检测时间
        /// </summary>
        [XmlElement("detect_time")]
        public string DetectTime { get; set; }

        /// <summary>
        /// 开发者
        /// </summary>
        [XmlElement("developer")]
        public string Developer { get; set; }

        /// <summary>
        /// 文件摘要
        /// </summary>
        [XmlElement("md_5")]
        public string Md5 { get; set; }

        /// <summary>
        /// 软件名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 包名
        /// </summary>
        [XmlElement("package_name")]
        public string PackageName { get; set; }

        /// <summary>
        /// 系统平台
        /// </summary>
        [XmlElement("platform")]
        public string Platform { get; set; }

        /// <summary>
        /// 隐私权政策url
        /// </summary>
        [XmlElement("privacy_policy")]
        public string PrivacyPolicy { get; set; }

        /// <summary>
        /// 集成sdk数量
        /// </summary>
        [XmlElement("sdk_sum")]
        public long SdkSum { get; set; }

        /// <summary>
        /// 签名证书
        /// </summary>
        [XmlElement("sign_certificate")]
        public string SignCertificate { get; set; }

        /// <summary>
        /// 文件体积大小，单位M
        /// </summary>
        [XmlElement("size")]
        public string Size { get; set; }

        /// <summary>
        /// targetSdkVersion
        /// </summary>
        [XmlElement("target_sdk_version")]
        public string TargetSdkVersion { get; set; }

        /// <summary>
        /// 检测任务id
        /// </summary>
        [XmlElement("task_id")]
        public string TaskId { get; set; }

        /// <summary>
        /// 测试机型
        /// </summary>
        [XmlElement("ut_name")]
        public string UtName { get; set; }
    }
}
