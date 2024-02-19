using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntMerchantExpandZftSettlementUnbindModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandZftSettlementUnbindModel : AopObject
    {
        /// <summary>
        /// 结算支付宝账号（与进件生成的卡编号二选其一）
        /// </summary>
        [XmlElement("alipay_logon_id")]
        public string AlipayLogonId { get; set; }

        /// <summary>
        /// 进件生成的卡编号（与结算支付宝账号二选其一）
        /// </summary>
        [XmlElement("card_alias_no")]
        public string CardAliasNo { get; set; }

        /// <summary>
        /// 二级商户ID
        /// </summary>
        [XmlElement("smid")]
        public string Smid { get; set; }
    }
}
