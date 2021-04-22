using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserDtbankcustChannelvoucherSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserDtbankcustChannelvoucherSendModel : AopObject
    {
        /// <summary>
        /// 数字分行活动id
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 登录ID 支付宝用户ID 。user_id, logon_id不能同时为空，优先级依次降低
        /// </summary>
        [XmlElement("logon_id")]
        public string LogonId { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 支付宝用户ID 。user_id, logon_id不能同时为空，优先级依次降低
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
