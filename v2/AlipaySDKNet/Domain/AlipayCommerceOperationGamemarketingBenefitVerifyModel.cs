using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceOperationGamemarketingBenefitVerifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceOperationGamemarketingBenefitVerifyModel : AopObject
    {
        /// <summary>
        /// 活动的编码
        /// </summary>
        [XmlElement("activity_code")]
        public string ActivityCode { get; set; }

        /// <summary>
        /// 权益策略扩展字段；用于合作伙伴厂商个性化的业务逻辑判断的参数，例如，首笔满6元，送A礼包，累计三笔额外送B礼包,那么可能需要传支付金额，以及是否首次等变量，需要咨询管理员进行使用
        /// </summary>
        [XmlArray("benefit_strategy_ext_info")]
        [XmlArrayItem("ext_info_map")]
        public List<ExtInfoMap> BenefitStrategyExtInfo { get; set; }

        /// <summary>
        /// 交易订单号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 厂商客户的唯一标识，手机号，身份证，账号id等
        /// </summary>
        [XmlElement("user_account")]
        public string UserAccount { get; set; }

        /// <summary>
        /// 卡券码
        /// </summary>
        [XmlElement("voucher_code")]
        public string VoucherCode { get; set; }
    }
}
