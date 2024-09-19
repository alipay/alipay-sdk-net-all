using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceSalaryTransferApplyResponse.
    /// </summary>
    public class AlipayCommerceSalaryTransferApplyResponse : AopResponse
    {
        /// <summary>
        /// 申请时间，申请成功时提供
        /// </summary>
        [XmlElement("apply_time")]
        public string ApplyTime { get; set; }

        /// <summary>
        /// 转账申请ID，用于后续实际发薪驱动时消费，申请成功时提供
        /// </summary>
        [XmlElement("salary_order_id")]
        public string SalaryOrderId { get; set; }

        /// <summary>
        /// 转账签名，申请成功时提供
        /// </summary>
        [XmlElement("sign_data")]
        public SalaryApplySignData SignData { get; set; }
    }
}
