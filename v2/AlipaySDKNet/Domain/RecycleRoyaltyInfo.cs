using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecycleRoyaltyInfo Data Structure.
    /// </summary>
    [Serializable]
    public class RecycleRoyaltyInfo : AopObject
    {
        /// <summary>
        /// 金额单位元，支持小数点后2位，必须大于0
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 分账说明，选填
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 分账收入方类型
        /// </summary>
        [XmlElement("role_type")]
        public string RoleType { get; set; }

        /// <summary>
        /// 转入方2088账户
        /// </summary>
        [XmlElement("trans_in")]
        public string TransIn { get; set; }

        /// <summary>
        /// 转入方登录id
        /// </summary>
        [XmlElement("trans_in_login_id")]
        public string TransInLoginId { get; set; }

        /// <summary>
        /// 转入方2088账户
        /// </summary>
        [XmlElement("trans_in_open_id")]
        public string TransInOpenId { get; set; }

        /// <summary>
        /// 接受分账金额的账户类型
        /// </summary>
        [XmlElement("trans_in_type")]
        public string TransInType { get; set; }

        /// <summary>
        /// 分账阶段 USER_CONFIRMED:用户确认 MERCHANT_RECEIVED_CONFIRMED:回收商确认收货
        /// </summary>
        [XmlElement("trans_stage")]
        public string TransStage { get; set; }
    }
}
