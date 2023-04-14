using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCreditEpDossierLevelQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditEpDossierLevelQueryModel : AopObject
    {
        /// <summary>
        /// 企业证件号：：企业社会统一信用代码或营业执照注册号
        /// </summary>
        [XmlElement("ep_cert_no")]
        public string EpCertNo { get; set; }
    }
}
