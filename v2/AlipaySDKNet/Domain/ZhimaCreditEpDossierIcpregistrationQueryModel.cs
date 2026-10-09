using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCreditEpDossierIcpregistrationQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditEpDossierIcpregistrationQueryModel : AopObject
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
        /// 分页中每页返回的结果条数，默认10，最大50
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// ICP备案产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }
    }
}
