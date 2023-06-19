using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppIndustryOnecodepassAgreementSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustryOnecodepassAgreementSyncModel : AopObject
    {
        /// <summary>
        /// 合约号
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 合约类型
        /// </summary>
        [XmlElement("agreement_type")]
        public string AgreementType { get; set; }

        /// <summary>
        /// 码类型
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 支付宝用户openid，和uid不能同时为空
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 合约状态 ON / OFF ON: 合约状态正常，用户正常展码 OFF: 禁码状态，根据statusCode提示用户合约异常行动点
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 合约不可用状态码，action=UPDATE status=OFF进行禁码时必填  CLOSE_WITHHOLD_AND_BALANCE_NOT_ENOUGH - 代扣解约且余额不足  ARREARAGE -欠费  CARD_RETUERN - 退卡申请中  UNILATERAL_RECORD - 存在单边记录  OTHER_DISABLED - 其他不能生码的情况
        /// </summary>
        [XmlElement("status_code")]
        public string StatusCode { get; set; }

        /// <summary>
        /// 合约异常下的提示
        /// </summary>
        [XmlElement("status_msg")]
        public string StatusMsg { get; set; }

        /// <summary>
        /// CREATE-创建合约 UPDATE-更新合约 REVOKE-注销
        /// </summary>
        [XmlElement("sync_action")]
        public string SyncAction { get; set; }

        /// <summary>
        /// 支付宝用户uid，和open_id不能同时为空
        /// </summary>
        [XmlElement("uid")]
        public string Uid { get; set; }
    }
}
