using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCreditEpDossierTaxviolationQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditEpDossierTaxviolationQueryModel : AopObject
    {
        /// <summary>
        /// 企业注册号或统一社会信用代码，一般为18位
        /// </summary>
        [XmlElement("ep_cert_no")]
        public string EpCertNo { get; set; }

        /// <summary>
        /// 分页用参数，代表请求结果的起始位置，默认1
        /// </summary>
        [XmlElement("page_index")]
        public long PageIndex { get; set; }

        /// <summary>
        /// 返回 size 条记录，默认值为10，最大值为50
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }
    }
}
