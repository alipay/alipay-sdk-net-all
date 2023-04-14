using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MybankCreditLoanapplyRzzlOpenSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankCreditLoanapplyRzzlOpenSendModel : AopObject
    {
        /// <summary>
        /// 业务类型,APPROVE_RESULT_NOTICE,资方发起审核结果请求,SDK枚举获取 业务类型,INVESTOR_INFO_SUPPLY_NOTICE,资方发起信息补传请求,SDK枚举获取 业务类型,INVESTOR_APPLY_LOAN_NOTICE,资方发起放款请求,SDK枚举获取
        /// </summary>
        [XmlElement("business_type")]
        public string BusinessType { get; set; }

        /// <summary>
        /// 业务字段
        /// </summary>
        [XmlElement("data_object")]
        public string DataObject { get; set; }
    }
}
