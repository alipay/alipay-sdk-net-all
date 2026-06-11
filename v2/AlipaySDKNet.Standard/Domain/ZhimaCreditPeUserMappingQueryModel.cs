using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCreditPeUserMappingQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditPeUserMappingQueryModel : AopObject
    {
        /// <summary>
        /// 开通/授权成功后生成的协议号，用于标记本次开通/授权的唯一标识
        /// </summary>
        [XmlElement("credit_agreement_id")]
        public string CreditAgreementId { get; set; }

        /// <summary>
        /// 标记本次请求的用户是否为首次开通：Y表示首次，N表示非首次
        /// </summary>
        [XmlElement("is_new_open")]
        public string IsNewOpen { get; set; }

        /// <summary>
        /// 查询操作类型：MAPPING_SCORE
        /// </summary>
        [XmlElement("mapping_type")]
        public string MappingType { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 用于表示本次请求的唯一请求单号
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 信用服务service_id； 芝麻侧通过商户PID生成的一个信用服务的id
        /// </summary>
        [XmlElement("service_id")]
        public string ServiceId { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
