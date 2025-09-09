using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcActivityVoucherSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcActivityVoucherSendModel : AopObject
    {
        /// <summary>
        /// 券活动id
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 员工id
        /// </summary>
        [XmlElement("employee_id")]
        public string EmployeeId { get; set; }

        /// <summary>
        /// 企业码企业id
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 业务自定义外部幂等号，同一个企业下使用相同的外部幂等号调用发券，不会重复发放，用于接口超时情况下的幂等重试
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
