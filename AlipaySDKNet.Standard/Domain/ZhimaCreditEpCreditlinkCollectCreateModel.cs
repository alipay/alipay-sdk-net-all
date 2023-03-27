using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCreditEpCreditlinkCollectCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditEpCreditlinkCollectCreateModel : AopObject
    {
        /// <summary>
        /// 请求数据类型
        /// </summary>
        [XmlElement("data_type")]
        public string DataType { get; set; }

        /// <summary>
        /// 企业的社会统一信用代码或营业执照注册号
        /// </summary>
        [XmlElement("ep_cert_no")]
        public string EpCertNo { get; set; }

        /// <summary>
        /// 企业名称
        /// </summary>
        [XmlElement("ep_name")]
        public string EpName { get; set; }

        /// <summary>
        /// 拓展信息
        /// </summary>
        [XmlElement("ext_info")]
        public CreateExtInfo ExtInfo { get; set; }

        /// <summary>
        /// 商户单号，请与授权申请时的单号保持一致
        /// </summary>
        [XmlElement("merchant_request_id")]
        public string MerchantRequestId { get; set; }
    }
}
