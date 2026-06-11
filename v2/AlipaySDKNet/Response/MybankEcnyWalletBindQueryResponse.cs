using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankEcnyWalletBindQueryResponse.
    /// </summary>
    public class MybankEcnyWalletBindQueryResponse : AopResponse
    {
        /// <summary>
        /// 绑定协议编号
        /// </summary>
        [XmlElement("bind_ar_no")]
        public string BindArNo { get; set; }

        /// <summary>
        /// 用户绑定时间
        /// </summary>
        [XmlElement("bind_time")]
        public string BindTime { get; set; }

        /// <summary>
        /// 钱包冻结类型
        /// </summary>
        [XmlElement("freeze_type")]
        public string FreezeType { get; set; }

        /// <summary>
        /// 是否有钱包已绑定至平台
        /// </summary>
        [XmlElement("has_bound")]
        public string HasBound { get; set; }

        /// <summary>
        /// 身份信息令牌。用于其他接口中密文传递用户信息。
        /// </summary>
        [XmlElement("identify_token")]
        public string IdentifyToken { get; set; }

        /// <summary>
        /// 钱包额度管控标识。若额度受管控，则钱包的各项限额将降至匿名钱包限额。
        /// </summary>
        [XmlElement("quota_control_flag")]
        public string QuotaControlFlag { get; set; }

        /// <summary>
        /// 用户在平台的身份
        /// </summary>
        [XmlElement("role_type")]
        public string RoleType { get; set; }

        /// <summary>
        /// 钱包编号
        /// </summary>
        [XmlElement("wallet_id")]
        public string WalletId { get; set; }

        /// <summary>
        /// 钱包等级。三类及以上钱包为实名钱包。
        /// </summary>
        [XmlElement("wallet_level")]
        public string WalletLevel { get; set; }

        /// <summary>
        /// 钱包状态
        /// </summary>
        [XmlElement("wallet_status")]
        public string WalletStatus { get; set; }
    }
}
