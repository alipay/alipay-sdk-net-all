using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineProviderNpassporterPrivacyQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineProviderNpassporterPrivacyQueryModel : AopObject
    {
        /// <summary>
        /// 支付宝uid
        /// </summary>
        [XmlElement("alipay_id")]
        public string AlipayId { get; set; }

        /// <summary>
        /// open_id
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("out_encrypt_cert_no_list")]
        [XmlArrayItem("string")]
        public List<string> OutEncryptCertNoList { get; set; }

        /// <summary>
        /// 项目ID
        /// </summary>
        [XmlElement("project_id")]
        public string ProjectId { get; set; }

        /// <summary>
        /// 方案类型
        /// </summary>
        [XmlElement("solution_type")]
        public string SolutionType { get; set; }

        /// <summary>
        /// 接入方传入具体活动场次唯一ID即可，此字段作为密算证件号的关键信息，即同一场次下的人群传统一ID即可，若不填写默认以“projectID”字段作为密算计算信息。接入方调用支付宝传入的场次ID，需跟自己按密算规则传入的ID保持一致，否则会出现两侧密算后信息无法匹配。
        /// </summary>
        [XmlElement("sub_project_id")]
        public string SubProjectId { get; set; }
    }
}
