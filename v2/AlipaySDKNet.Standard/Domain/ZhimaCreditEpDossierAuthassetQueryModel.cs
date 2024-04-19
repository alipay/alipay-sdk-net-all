using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCreditEpDossierAuthassetQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditEpDossierAuthassetQueryModel : AopObject
    {
        /// <summary>
        /// 企业资产类型： OP_CERTIFICATE(经营资质证照), OP_PATENT(经营专利)
        /// </summary>
        [XmlArray("ep_asset_type_list")]
        [XmlArrayItem("string")]
        public List<string> EpAssetTypeList { get; set; }

        /// <summary>
        /// 企业证件号：：企业社会统一信用代码或营业执照注册号
        /// </summary>
        [XmlElement("ep_cert_no")]
        public string EpCertNo { get; set; }
    }
}
