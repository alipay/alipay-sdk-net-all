using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCreditEpCreditlinkCollectBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditEpCreditlinkCollectBatchqueryModel : AopObject
    {
        /// <summary>
        /// 请求数据类型，商户请使用以签约的数据类型
        /// </summary>
        [XmlElement("data_type")]
        public string DataType { get; set; }

        /// <summary>
        /// 企业的社会统一信用代码或营业执照注册号
        /// </summary>
        [XmlElement("ep_cert_no")]
        public string EpCertNo { get; set; }

        /// <summary>
        /// 商户单号，请与授权申请时的单号保持一致
        /// </summary>
        [XmlElement("merchant_request_id")]
        public string MerchantRequestId { get; set; }

        /// <summary>
        /// 批量获取数据的页码大小，默认从第一页开始，不可以为0
        /// </summary>
        [XmlElement("page_number")]
        public long PageNumber { get; set; }
    }
}
