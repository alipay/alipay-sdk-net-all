using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundWalletOrderQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundWalletOrderQueryModel : AopObject
    {
        /// <summary>
        /// 单据号 支持充值、充退和提现的单号
        /// </summary>
        [XmlElement("bill_no")]
        public string BillNo { get; set; }

        /// <summary>
        /// 查询单据类型：  DEPOSIT  — 充值；  DEPOSIT_BACK — 退款；  WITHDRAW — 提现；
        /// </summary>
        [XmlElement("bill_type")]
        public string BillType { get; set; }

        /// <summary>
        /// 场景码
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 用户钱包Id
        /// </summary>
        [XmlElement("user_wallet_id")]
        public string UserWalletId { get; set; }
    }
}
