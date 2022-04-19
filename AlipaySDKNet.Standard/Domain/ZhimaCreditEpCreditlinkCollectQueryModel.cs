using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCreditEpCreditlinkCollectQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditEpCreditlinkCollectQueryModel : AopObject
    {
        /// <summary>
        /// 请求数据类型
        /// </summary>
        [XmlElement("data_type")]
        public string DataType { get; set; }

        /// <summary>
        /// 被查询企业的社会统一信用代码或营业执照注册号
        /// </summary>
        [XmlElement("ep_cert_no")]
        public string EpCertNo { get; set; }

        /// <summary>
        /// 商户单号，请与授权申请时的单号保持一致
        /// </summary>
        [XmlElement("merchant_request_id")]
        public string MerchantRequestId { get; set; }
    }
}
