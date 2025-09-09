using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCreditEpDossierBasicinfoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditEpDossierBasicinfoQueryModel : AopObject
    {
        /// <summary>
        /// 企业注册号或统一社会信用代码，一般为18位
        /// </summary>
        [XmlElement("ep_cert_no")]
        public string EpCertNo { get; set; }

        /// <summary>
        /// 企业工商信息查询产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }
    }
}
