using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecycleDeductQueryVO Data Structure.
    /// </summary>
    [Serializable]
    public class RecycleDeductQueryVO : AopObject
    {
        /// <summary>
        /// 绑定状态
        /// </summary>
        [XmlElement("bind_status")]
        public string BindStatus { get; set; }

        /// <summary>
        /// 绑定的收款钱包
        /// </summary>
        [XmlElement("bind_wallet_id")]
        public string BindWalletId { get; set; }

        /// <summary>
        /// 代扣关系支付类型
        /// </summary>
        [XmlElement("bind_wallet_type")]
        public string BindWalletType { get; set; }

        /// <summary>
        /// 商户openId
        /// </summary>
        [XmlElement("merchant_open_id")]
        public string MerchantOpenId { get; set; }

        /// <summary>
        /// 商户pid
        /// </summary>
        [XmlElement("merchant_pid")]
        public string MerchantPid { get; set; }

        /// <summary>
        /// 二级商户openId
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
