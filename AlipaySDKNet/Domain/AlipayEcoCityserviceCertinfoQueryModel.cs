using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoCityserviceCertinfoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoCityserviceCertinfoQueryModel : AopObject
    {
        /// <summary>
        /// 用户证件信息列表。
        /// </summary>
        [XmlArray("cert_infos")]
        [XmlArrayItem("cert_info_request")]
        public List<CertInfoRequest> CertInfos { get; set; }
    }
}
