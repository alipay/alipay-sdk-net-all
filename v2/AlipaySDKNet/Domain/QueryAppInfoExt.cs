using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// QueryAppInfoExt Data Structure.
    /// </summary>
    [Serializable]
    public class QueryAppInfoExt : AopObject
    {
        /// <summary>
        /// 该应用的应用名称
        /// </summary>
        [XmlElement("app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// 该应用的APPID
        /// </summary>
        [XmlElement("app_number")]
        public string AppNumber { get; set; }

        /// <summary>
        /// 该应用的应用类型, 如:网页应用, 小程序等
        /// </summary>
        [XmlElement("application_type")]
        public string ApplicationType { get; set; }

        /// <summary>
        /// 授权回调地址
        /// </summary>
        [XmlElement("callback_url")]
        public string CallbackUrl { get; set; }

        /// <summary>
        /// 编码格式
        /// </summary>
        [XmlElement("charset_type")]
        public string CharsetType { get; set; }

        /// <summary>
        /// 开发者ID
        /// </summary>
        [XmlElement("dev_id")]
        public string DevId { get; set; }

        /// <summary>
        /// 网关地址
        /// </summary>
        [XmlElement("gateway_url")]
        public string GatewayUrl { get; set; }

        /// <summary>
        /// 该APPID所挂载的所有功能包编码
        /// </summary>
        [XmlArray("package_code_set")]
        [XmlArrayItem("string")]
        public List<string> PackageCodeSet { get; set; }

        /// <summary>
        /// 签约主体商户PID
        /// </summary>
        [XmlElement("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 签名类型
        /// </summary>
        [XmlElement("signature_type")]
        public string SignatureType { get; set; }

        /// <summary>
        /// 是否可用
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 是否强制加密
        /// </summary>
        [XmlElement("use_encrypt")]
        public bool UseEncrypt { get; set; }
    }
}
