using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCreditEpRiskShellIdentifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditEpRiskShellIdentifyModel : AopObject
    {
        /// <summary>
        /// 企业统一社会信用代码或者注册号
        /// </summary>
        [XmlElement("ep_cert_no")]
        public string EpCertNo { get; set; }
    }
}
