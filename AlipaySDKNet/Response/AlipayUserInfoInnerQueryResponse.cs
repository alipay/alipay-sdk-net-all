using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserInfoInnerQueryResponse.
    /// </summary>
    public class AlipayUserInfoInnerQueryResponse : AopResponse
    {
        /// <summary>
        /// 绑定手机号码
        /// </summary>
        [XmlElement("binded_mobile")]
        public string BindedMobile { get; set; }

        /// <summary>
        /// 优先返回登录邮箱，若邮箱不存在，返回其他登录号（登录手机号）
        /// </summary>
        [XmlElement("email")]
        public string Email { get; set; }

        /// <summary>
        /// 阿里集团统一ID
        /// </summary>
        [XmlElement("havana_id")]
        public string HavanaId { get; set; }

        /// <summary>
        /// 金融机构或特殊单位 I:金融机构 C:特殊单位 N:非金融机构或特殊单位
        /// </summary>
        [XmlElement("inst_type")]
        public string InstType { get; set; }

        /// <summary>
        /// 账户是否禁止提现，T是，F否
        /// </summary>
        [XmlElement("is_forbidden_withdraw")]
        public string IsForbiddenWithdraw { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 用户状态
        /// </summary>
        [XmlElement("user_status")]
        public string UserStatus { get; set; }
    }
}
