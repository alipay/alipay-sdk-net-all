using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcCreditApproveModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcCreditApproveModel : AopObject
    {
        /// <summary>
        /// 资方授信申请流水号， 资方内部生成
        /// </summary>
        [XmlElement("apply_serial_no")]
        public string ApplySerialNo { get; set; }

        /// <summary>
        /// 申请时间，格式"yyyy-MM-dd HH:mm:ss"
        /// </summary>
        [XmlElement("apply_time")]
        public string ApplyTime { get; set; }

        /// <summary>
        /// 剩余可用额度，单位元，精确到分
        /// </summary>
        [XmlElement("available_limit")]
        public string AvailableLimit { get; set; }

        /// <summary>
        /// 授信额度，申请完成时必填，必须为整数
        /// </summary>
        [XmlElement("capital_limit")]
        public string CapitalLimit { get; set; }

        /// <summary>
        /// 企业ID
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 额度有效期
        /// </summary>
        [XmlElement("expiration_date")]
        public string ExpirationDate { get; set; }

        /// <summary>
        /// 授信申请时传递的外部请求号，平台基于该字段匹配申请记录
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 授信失败时，需要返回的具体原因
        /// </summary>
        [XmlElement("rejected_reason")]
        public string RejectedReason { get; set; }

        /// <summary>
        /// 授信申请状态
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }
    }
}
