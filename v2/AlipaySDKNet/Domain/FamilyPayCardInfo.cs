using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FamilyPayCardInfo Data Structure.
    /// </summary>
    [Serializable]
    public class FamilyPayCardInfo : AopObject
    {
        /// <summary>
        /// 代扣协议号
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 申请单号
        /// </summary>
        [XmlElement("apply_no")]
        public string ApplyNo { get; set; }

        /// <summary>
        /// 亲情卡唯一id
        /// </summary>
        [XmlElement("card_id")]
        public string CardId { get; set; }

        /// <summary>
        /// 亲情卡领取时间（亲情卡生效激活生效时间）
        /// </summary>
        [XmlElement("gmt_valid")]
        public string GmtValid { get; set; }

        /// <summary>
        /// 商户侧签约流水号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 赠卡人支付宝用户id
        /// </summary>
        [XmlElement("payer_id")]
        public string PayerId { get; set; }

        /// <summary>
        /// 赠卡人支付宝用户id
        /// </summary>
        [XmlElement("payer_open_id")]
        public string PayerOpenId { get; set; }

        /// <summary>
        /// 亲情卡额度信息
        /// </summary>
        [XmlElement("quota")]
        public FamilyPayQuotaInfo Quota { get; set; }

        /// <summary>
        /// 亲情卡剩余额度（单位:元）
        /// </summary>
        [XmlElement("quota_remain")]
        public string QuotaRemain { get; set; }

        /// <summary>
        /// 额度支付（单位:元）
        /// </summary>
        [XmlElement("quota_used")]
        public string QuotaUsed { get; set; }

        /// <summary>
        /// 收卡人支付宝id
        /// </summary>
        [XmlElement("spender_id")]
        public string SpenderId { get; set; }

        /// <summary>
        /// 收卡人支付宝id
        /// </summary>
        [XmlElement("spender_open_id")]
        public string SpenderOpenId { get; set; }

        /// <summary>
        /// 签约状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
