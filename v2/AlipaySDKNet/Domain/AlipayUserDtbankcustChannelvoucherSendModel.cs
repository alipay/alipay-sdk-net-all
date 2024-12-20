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
        /// 支付宝用户ID 。当不传入specify_user_info字段时：user_id，open_id，logon_id，phone_id不能同时为空，优先级依次降低；当传入specify_user_info字段时：不可传入logon_id字段。 注：若手机号为非用户注册支付宝账号，则会发放失败。
        /// </summary>
        [XmlElement("logon_id")]
        public string LogonId { get; set; }

        /// <summary>
        /// 映射user_id
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 该参数将先匹配用户手机号对应支付宝账号，若存在且完成实名认证则以此支付宝账号发放，若该支付宝账号未完成实名认证则发放失败；若用户手机号对应支付宝账号不存在，则再匹配用户手机号绑定支付宝账号。若用户手机号绑定多个支付宝账号，则以系统判定的常用支付宝账号为准。请优先使用user_id和logon_id。
        /// </summary>
        [XmlElement("phone_id")]
        public string PhoneId { get; set; }

        /// <summary>
        /// 适用于通过指定主体的appid和指定openid解析出对应userid发奖，specify_user_info发奖需先找BD申请加白
        /// </summary>
        [XmlElement("specify_user_info")]
        public SpecifyUserInfo SpecifyUserInfo { get; set; }

        /// <summary>
        /// 支付宝用户ID 。当不传入specify_user_info字段时：user_id，open_id，logon_id，phone_id不能同时为空，优先级依次降低；当传入specify_user_info字段时：不可传入user_id字段。 注：UID为用户唯一标识，可通过授权方式获取，具体见产品文档。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
