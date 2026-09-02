using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DepositQueryOpenResult Data Structure.
    /// </summary>
    [Serializable]
    public class DepositQueryOpenResult : AopObject
    {
        /// <summary>
        /// 出资账户名称
        /// </summary>
        [XmlElement("deposit_account_name")]
        public string DepositAccountName { get; set; }

        /// <summary>
        /// 出资银行卡号
        /// </summary>
        [XmlElement("deposit_account_no")]
        public string DepositAccountNo { get; set; }

        /// <summary>
        /// 出资银行名称
        /// </summary>
        [XmlElement("deposit_bank_name")]
        public string DepositBankName { get; set; }

        /// <summary>
        /// 当前订单金额(单位：元)
        /// </summary>
        [XmlElement("order_amount")]
        public string OrderAmount { get; set; }

        /// <summary>
        /// 资金待调拨订单ID
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 外部订单号，用于服务商上幂等使用
        /// </summary>
        [XmlElement("outer_order_id")]
        public string OuterOrderId { get; set; }

        /// <summary>
        /// 自然人名称
        /// </summary>
        [XmlElement("seller_name")]
        public string SellerName { get; set; }
    }
}
