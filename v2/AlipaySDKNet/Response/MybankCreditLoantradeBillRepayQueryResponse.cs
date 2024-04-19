using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankCreditLoantradeBillRepayQueryResponse.
    /// </summary>
    public class MybankCreditLoantradeBillRepayQueryResponse : AopResponse
    {
        /// <summary>
        /// 调用失败报错信息
        /// </summary>
        [XmlElement("refuse_msg")]
        public RefuseVo RefuseMsg { get; set; }

        /// <summary>
        /// 账单还款结果
        /// </summary>
        [XmlElement("repay_result")]
        public BillRepayResult RepayResult { get; set; }

        /// <summary>
        /// 是否调用成功
        /// </summary>
        [XmlElement("succ")]
        public bool Succ { get; set; }
    }
}
