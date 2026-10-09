using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenCloudAppSecCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenCloudAppSecCreateModel : AopObject
    {
        /// <summary>
        /// 云id
        /// </summary>
        [XmlElement("cloud_id")]
        public string CloudId { get; set; }

        /// <summary>
        /// 云环境id
        /// </summary>
        [XmlElement("env_id")]
        public string EnvId { get; set; }

        /// <summary>
        /// 调用应用id
        /// </summary>
        [XmlElement("invoke_app_id")]
        public string InvokeAppId { get; set; }

        /// <summary>
        /// 请求签名算法
        /// </summary>
        [XmlElement("req_sign_type")]
        public string ReqSignType { get; set; }

        /// <summary>
        /// 密钥内容
        /// </summary>
        [XmlElement("sec_content")]
        public string SecContent { get; set; }

        /// <summary>
        /// 密钥类型
        /// </summary>
        [XmlElement("sec_type")]
        public string SecType { get; set; }
    }
}
