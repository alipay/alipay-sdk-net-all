using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCreditEpDossierNameMatchModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditEpDossierNameMatchModel : AopObject
    {
        /// <summary>
        /// 企业全称
        /// </summary>
        [XmlElement("ep_name")]
        public string EpName { get; set; }

        /// <summary>
        /// 企业类别范围: ENTERPRISE(企业)， INDIVIDUAL（个体工商户), ORGANIZATION(组织机构), ALL(全部，默认)
        /// </summary>
        [XmlElement("ep_type_scope")]
        public string EpTypeScope { get; set; }
    }
}
