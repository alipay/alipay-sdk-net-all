using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PayerAccountDTO Data Structure.
    /// </summary>
    [Serializable]
    public class PayerAccountDTO : AopObject
    {
        /// <summary>
        /// 资产展示名
        /// </summary>
        [XmlElement("asset_display_name")]
        public string AssetDisplayName { get; set; }

        /// <summary>
        /// 资产类型<br> - DEFAULT_BALANCE：余额<br> - YUEBAO：余额宝<br> - BANK_CARD：银行卡<br> - POLLING_PAY：按支付宝APP内设定的支付方式优先级轮训扣款
        /// </summary>
        [XmlElement("asset_type")]
        public string AssetType { get; set; }
    }
}
