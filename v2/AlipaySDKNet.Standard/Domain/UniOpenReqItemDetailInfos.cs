using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// UniOpenReqItemDetailInfos Data Structure.
    /// </summary>
    [Serializable]
    public class UniOpenReqItemDetailInfos : AopObject
    {
        /// <summary>
        /// default_settle_type为空，默认为alipayAccount，结算账号默认为支付宝余额户； 当default_settle_type为alipayWallet时，default_settle_target为钱包id；
        /// </summary>
        [XmlElement("default_settle_target")]
        public string DefaultSettleTarget { get; set; }

        /// <summary>
        /// 默认结算账号类型。 开通个人收款时，若聚合开通钱包，则无需填写该参数，默认会将钱包设置为默认结算账号 若钱包已经开通，仅需开通个人收款且需要将钱包设置为默认结算账号需传入该值为alipayWallet
        /// </summary>
        [XmlElement("default_settle_type")]
        public string DefaultSettleType { get; set; }

        /// <summary>
        /// PERSONAL:个人用户（默认值） PERSONAL_MERCHANTS：个人商户
        /// </summary>
        [XmlElement("merchant_type")]
        public string MerchantType { get; set; }

        /// <summary>
        /// 钱包提现时平台是否需要收取提现手续费
        /// </summary>
        [XmlElement("need_withdraw_platform_fee")]
        public string NeedWithdrawPlatformFee { get; set; }

        /// <summary>
        /// 进件申请单id，与接口中传入的申请单id一致
        /// </summary>
        [XmlElement("sub_merchant_order_id")]
        public string SubMerchantOrderId { get; set; }

        /// <summary>
        /// 固定值
        /// </summary>
        [XmlElement("wallet_biz_product")]
        public string WalletBizProduct { get; set; }

        /// <summary>
        /// 固定值
        /// </summary>
        [XmlElement("wallet_biz_scene")]
        public string WalletBizScene { get; set; }

        /// <summary>
        /// 钱包模版id 调用alipay.fund.wallet.template.create接口返回的wallet_template_id
        /// </summary>
        [XmlElement("wallet_template_id")]
        public string WalletTemplateId { get; set; }
    }
}
