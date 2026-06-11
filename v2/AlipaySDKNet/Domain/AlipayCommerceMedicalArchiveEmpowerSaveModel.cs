using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalArchiveEmpowerSaveModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalArchiveEmpowerSaveModel : AopObject
    {
        /// <summary>
        /// 认证令牌
        /// </summary>
        [XmlElement("access_token")]
        public string AccessToken { get; set; }

        /// <summary>
        /// 授权操作类型
        /// </summary>
        [XmlElement("auth_action")]
        public string AuthAction { get; set; }

        /// <summary>
        /// 授权码
        /// </summary>
        [XmlElement("auth_code")]
        public string AuthCode { get; set; }

        /// <summary>
        /// 授权状态
        /// </summary>
        [XmlElement("auth_status")]
        public string AuthStatus { get; set; }

        /// <summary>
        /// 数据来源
        /// </summary>
        [XmlElement("data_source")]
        public string DataSource { get; set; }

        /// <summary>
        /// 康乃心授权信息
        /// </summary>
        [XmlElement("knx_auth_datail")]
        public KnxAuthDetail KnxAuthDatail { get; set; }

        /// <summary>
        /// 健康档案成员id
        /// </summary>
        [XmlElement("member_id")]
        public string MemberId { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
