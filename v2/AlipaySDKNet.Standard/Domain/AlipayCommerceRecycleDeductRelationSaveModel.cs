using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceRecycleDeductRelationSaveModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceRecycleDeductRelationSaveModel : AopObject
    {
        /// <summary>
        /// 绑定的收款钱包信息Id 场景钱包:钱包id，余额：userId
        /// </summary>
        [XmlElement("bind_wallet_id")]
        public string BindWalletId { get; set; }

        /// <summary>
        /// 代扣关系支付类型
        /// </summary>
        [XmlElement("bind_wallet_type")]
        public string BindWalletType { get; set; }

        /// <summary>
        /// 代扣关系绑定类型
        /// </summary>
        [XmlElement("handle_type")]
        public string HandleType { get; set; }

        /// <summary>
        /// 二级商户openid
        /// </summary>
        [XmlElement("second_merchant_open_id")]
        public string SecondMerchantOpenId { get; set; }

        /// <summary>
        /// 二级商户pid
        /// </summary>
        [XmlElement("second_merchant_pid")]
        public string SecondMerchantPid { get; set; }
    }
}
