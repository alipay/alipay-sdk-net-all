using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoCityserviceIndustrymsgAuthBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoCityserviceIndustrymsgAuthBatchqueryModel : AopObject
    {
        /// <summary>
        /// 用户身份信息列表，传入上限为100条
        /// </summary>
        [XmlArray("certificate_info_list")]
        [XmlArrayItem("certificate_info")]
        public List<CertificateInfo> CertificateInfoList { get; set; }

        /// <summary>
        /// 行业类型，目前可选： 1：社保 2：公积金 3：交管 4：公安非交管 5：医保
        /// </summary>
        [XmlElement("industry_type")]
        public long IndustryType { get; set; }
    }
}
