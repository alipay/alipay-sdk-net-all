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
        /// 合约状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 合约不可用状态码，action=UPDATE status=OFF进行禁码时必填
        /// </summary>
        [XmlElement("status_code")]
        public string StatusCode { get; set; }

        /// <summary>
        /// 合约异常下的提示
        /// </summary>
        [XmlElement("status_msg")]
        public string StatusMsg { get; set; }

        /// <summary>
        /// 同步操作
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
