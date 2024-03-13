using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantIsvhelpEntryQueryResponse.
    /// </summary>
    public class AlipayMerchantIsvhelpEntryQueryResponse : AopResponse
    {
        /// <summary>
        /// 支付宝账号
        /// </summary>
        [XmlElement("alipay_logon_id")]
        public string AlipayLogonId { get; set; }

        /// <summary>
        /// 服务商代入驻申请单状态枚举
        /// </summary>
        [XmlElement("biz_status")]
        public string BizStatus { get; set; }

        /// <summary>
        /// 用户通过访问该链接进行认证
        /// </summary>
        [XmlElement("certify_link")]
        public string CertifyLink { get; set; }

        /// <summary>
        /// 服务商自定义的申请编号，每个申请编号唯一对应一个申请单，需在服务商下唯一。只能用数字、字母或下划线组成
        /// </summary>
        [XmlElement("external_id")]
        public string ExternalId { get; set; }

        /// <summary>
        /// 入驻申请单申请失败原因，其为字符串数组经序列化后字符串值。
        /// </summary>
        [XmlArray("failed_reason")]
        [XmlArrayItem("string")]
        public List<string> FailedReason { get; set; }
    }
}
