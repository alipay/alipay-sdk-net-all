using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EpSearchBasicInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EpSearchBasicInfo : AopObject
    {
        /// <summary>
        /// 企业统一社会信用代码或注册号
        /// </summary>
        [XmlElement("ep_cert_no")]
        public string EpCertNo { get; set; }

        /// <summary>
        /// 标准工商企业名称
        /// </summary>
        [XmlElement("ep_name")]
        public string EpName { get; set; }
    }
}
