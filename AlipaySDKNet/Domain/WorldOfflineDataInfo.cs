using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// WorldOfflineDataInfo Data Structure.
    /// </summary>
    [Serializable]
    public class WorldOfflineDataInfo : AopObject
    {
        /// <summary>
        /// 生码模式
        /// </summary>
        [XmlElement("auth_mode")]
        public string AuthMode { get; set; }

        /// <summary>
        /// 可用票种
        /// </summary>
        [XmlArray("available_ticket_types")]
        [XmlArrayItem("world_ticket_type")]
        public List<WorldTicketType> AvailableTicketTypes { get; set; }

        /// <summary>
        /// 凭证服务类型
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 配置信息
        /// </summary>
        [XmlElement("config")]
        public string Config { get; set; }

        /// <summary>
        /// 数据来源
        /// </summary>
        [XmlElement("data_from")]
        public string DataFrom { get; set; }

        /// <summary>
        /// 签名失效时间（long类型数据）
        /// </summary>
        [XmlElement("expire_time")]
        public long ExpireTime { get; set; }

        /// <summary>
        /// 脱机数据
        /// </summary>
        [XmlElement("offline_data")]
        public string OfflineData { get; set; }

        /// <summary>
        /// 用户秘钥
        /// </summary>
        [XmlElement("private_key")]
        public string PrivateKey { get; set; }

        /// <summary>
        /// 二维码数据
        /// </summary>
        [XmlElement("qrcode")]
        public string Qrcode { get; set; }

        /// <summary>
        /// 脚本mac
        /// </summary>
        [XmlElement("script_mac")]
        public string ScriptMac { get; set; }

        /// <summary>
        /// 脚本名称
        /// </summary>
        [XmlElement("script_name")]
        public string ScriptName { get; set; }

        /// <summary>
        /// 脚本类型
        /// </summary>
        [XmlElement("script_type")]
        public string ScriptType { get; set; }

        /// <summary>
        /// 上传原始码开关
        /// </summary>
        [XmlElement("upload_raw_code")]
        public bool UploadRawCode { get; set; }

        /// <summary>
        /// 启动脚本生码
        /// </summary>
        [XmlElement("use_script")]
        public bool UseScript { get; set; }
    }
}
