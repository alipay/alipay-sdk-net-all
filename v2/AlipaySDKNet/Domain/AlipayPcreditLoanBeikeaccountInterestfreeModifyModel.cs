using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayPcreditLoanBeikeaccountInterestfreeModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPcreditLoanBeikeaccountInterestfreeModifyModel : AopObject
    {
        /// <summary>
        /// 扣减和发放的时候需要用到的金额，无小数，必须为正整数
        /// </summary>
        [XmlElement("operation_amount")]
        public long OperationAmount { get; set; }

        /// <summary>
        /// 操作类型（额度查询，额度扣减，额度发放）
        /// </summary>
        [XmlElement("operation_type")]
        public long OperationType { get; set; }

        /// <summary>
        /// 扣减和发放的业务id，用于幂等防重
        /// </summary>
        [XmlElement("outer_biz_no")]
        public string OuterBizNo { get; set; }

        /// <summary>
        /// 操作场景（XXX小游戏），具体传入值，询问接口开发人员
        /// </summary>
        [XmlElement("scenes")]
        public string Scenes { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
