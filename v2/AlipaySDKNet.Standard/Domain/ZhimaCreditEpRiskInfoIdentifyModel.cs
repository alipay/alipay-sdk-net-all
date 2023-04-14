using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCreditEpRiskInfoIdentifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditEpRiskInfoIdentifyModel : AopObject
    {
        /// <summary>
        /// 企业注册号或统一社会信用代码
        /// </summary>
        [XmlElement("ep_cert_no")]
        public string EpCertNo { get; set; }

        /// <summary>
        /// 企业全称
        /// </summary>
        [XmlElement("ep_name")]
        public string EpName { get; set; }

        /// <summary>
        /// 业务场景码
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }
    }
}
