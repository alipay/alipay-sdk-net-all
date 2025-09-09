using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudpromoAgentUserModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudpromoAgentUserModifyModel : AopObject
    {
        /// <summary>
        /// 用户证件
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 商户自定义的用户Id。
        /// </summary>
        [XmlElement("custom_id")]
        public string CustomId { get; set; }

        /// <summary>
        /// 智能体实例id
        /// </summary>
        [XmlElement("instance_id")]
        public string InstanceId { get; set; }

        /// <summary>
        /// 用户手机
        /// </summary>
        [XmlElement("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 用户名字
        /// </summary>
        [XmlElement("user_name")]
        public string UserName { get; set; }
    }
}
