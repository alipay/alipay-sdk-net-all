using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EpDossierLiteDetail Data Structure.
    /// </summary>
    [Serializable]
    public class EpDossierLiteDetail : AopObject
    {
        /// <summary>
        /// 统一社会信用代码或营业执照注册号
        /// </summary>
        [XmlElement("ep_cert_no")]
        public string EpCertNo { get; set; }

        /// <summary>
        /// 企业全称
        /// </summary>
        [XmlElement("ep_name")]
        public string EpName { get; set; }

        /// <summary>
        /// 经营状态，如存续、在业、吊销、注销、迁入、迁出等
        /// </summary>
        [XmlElement("ep_status")]
        public string EpStatus { get; set; }

        /// <summary>
        /// 企业类型 ENTERPRISE (企业)， INDIVIDUAL（个体工商户) ORGANIZATION(组织机构)
        /// </summary>
        [XmlElement("ep_type")]
        public string EpType { get; set; }
    }
}
