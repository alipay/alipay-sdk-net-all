using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecycleDeductOutVO Data Structure.
    /// </summary>
    [Serializable]
    public class RecycleDeductOutVO : AopObject
    {
        /// <summary>
        /// 当出资类型=余额，传入出资账户2088. 当出资类型=钱包，传入出资账户钱包ID
        /// </summary>
        [XmlElement("deduct_out")]
        public string DeductOut { get; set; }

        /// <summary>
        /// 当出资类型=余额，传入出资账户2088. 当出资类型=钱包，传入出资账户钱包ID
        /// </summary>
        [XmlElement("deduct_out_open_id")]
        public string DeductOutOpenId { get; set; }

        /// <summary>
        /// 出资类型枚举 ● 用户余额户：balance ● 用户余额户openId：balanceOpenId ● 场景钱包：platformCard
        /// </summary>
        [XmlElement("deduct_out_type")]
        public string DeductOutType { get; set; }

        /// <summary>
        /// 出资方的身份标识
        /// </summary>
        [XmlElement("deduct_pid")]
        public string DeductPid { get; set; }

        /// <summary>
        /// 出资方的身份标识
        /// </summary>
        [XmlElement("deduct_pid_open_id")]
        public string DeductPidOpenId { get; set; }
    }
}
