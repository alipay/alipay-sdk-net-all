using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntMerchantExpandContractStatusQueryResponse.
    /// </summary>
    public class AntMerchantExpandContractStatusQueryResponse : AopResponse
    {
        /// <summary>
        /// 签约状态结果补充说明，如：账户被冻结，无法签约
        /// </summary>
        [XmlElement("sign_result_desc")]
        public string SignResultDesc { get; set; }

        /// <summary>
        /// 签约状态描述：     SIGNED 已签约  SIGNING 签约中  NEVER_SIGNED 未签约   SIGN_FAILED  签约失败
        /// </summary>
        [XmlElement("sign_status")]
        public string SignStatus { get; set; }
    }
}
