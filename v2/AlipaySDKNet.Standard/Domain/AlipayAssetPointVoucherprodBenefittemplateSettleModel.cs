using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayAssetPointVoucherprodBenefittemplateSettleModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayAssetPointVoucherprodBenefittemplateSettleModel : AopObject
    {
        /// <summary>
        /// 资产id，即权益模板id
        /// </summary>
        [XmlElement("asset_id")]
        public string AssetId { get; set; }

        /// <summary>
        /// 业务时间，即当前业务发生的时间
        /// </summary>
        [XmlElement("biz_dt")]
        public string BizDt { get; set; }

        /// <summary>
        /// 业务号，用于保证幂等，业务系统保证其唯一性
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 结算收款方账号
        /// </summary>
        [XmlElement("partner_settle_id")]
        public string PartnerSettleId { get; set; }

        /// <summary>
        /// 结算收款方的账号类型，LOGON_ID表示登录账号，USER_ID表示支付宝会员id
        /// </summary>
        [XmlElement("partner_settle_id_type")]
        public string PartnerSettleIdType { get; set; }

        /// <summary>
        /// 结算金额，单位元
        /// </summary>
        [XmlElement("settle_amount")]
        public string SettleAmount { get; set; }

        /// <summary>
        /// 结算日期，这笔结算业务的结算时间（可以与业务时间不同）
        /// </summary>
        [XmlElement("settle_date")]
        public string SettleDate { get; set; }

        /// <summary>
        /// 支付宝会员id，需要结算的权益模版所属商户的支付宝会员id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
