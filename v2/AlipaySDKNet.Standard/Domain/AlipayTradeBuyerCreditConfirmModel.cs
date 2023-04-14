using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayTradeBuyerCreditConfirmModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeBuyerCreditConfirmModel : AopObject
    {
        /// <summary>
        /// 卖家授信拆分给买家的额度  单位为元，精确到小数点后两位，取值范围[0.01,100000000]
        /// </summary>
        [XmlElement("grant_credit_quota")]
        public string GrantCreditQuota { get; set; }

        /// <summary>
        /// 本次授信拆分的操作明细单号，每一次授信申请或者关闭会生成唯一个单号
        /// </summary>
        [XmlElement("grant_operation_no")]
        public string GrantOperationNo { get; set; }
    }
}
