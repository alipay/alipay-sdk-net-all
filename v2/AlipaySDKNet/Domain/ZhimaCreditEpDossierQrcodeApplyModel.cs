using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCreditEpDossierQrcodeApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditEpDossierQrcodeApplyModel : AopObject
    {
        /// <summary>
        /// 企业社会统一信用代码或营业执照注册号
        /// </summary>
        [XmlElement("ep_cert_no")]
        public string EpCertNo { get; set; }
    }
}
