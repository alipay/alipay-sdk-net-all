using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcEnterpriseRegisterinviteCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcEnterpriseRegisterinviteCreateModel : AopObject
    {
        /// <summary>
        /// 企业基本信息，仅用于企业注册页面回显信息，用户可编辑修改，请按需使用
        /// </summary>
        [XmlElement("base_info")]
        public EnterpriseBaseInfoDTO BaseInfo { get; set; }

        /// <summary>
        /// 企业管理员身份唯一标识，搭配 identity_type 传参：<br/> 1. 当identity_type=ALIPAY_USER_ID时，identity传支付宝会员uid（此时可与identity_open_id二选一）<br/>  2. 当identity_type=ALIPAY_LOGON_ID时，identity传已注册支付宝且可以登录支付宝的手机号或邮箱 ；<br/> 3. 当identity_type=ISV_USER_ID时，identity传服务商生成的用户唯一标识；<br/> 4. 当identity_type=ENTERPRISE_EMAIL时，identity传企业邮箱；
        /// </summary>
        [XmlElement("identity")]
        public string Identity { get; set; }

        /// <summary>
        /// 企业管理员身份标识openId
        /// </summary>
        [XmlElement("identity_open_id")]
        public string IdentityOpenId { get; set; }

        /// <summary>
        /// 企业管理员身份类型
        /// </summary>
        [XmlElement("identity_type")]
        public string IdentityType { get; set; }

        /// <summary>
        /// 服务商生成的请求唯一流水号/业务幂等号；<br/> 字段作用：<br/> 1. 作为邀请注册的幂等标识，使用相同的out_biz_no 会得到相同的注册链接（若链接未使用过期，会重新生成）<br/> 2. 使用相同的身份标识（identity）传入不同的out_biz_no 可生成不同的链接，适用于一个用户注册多个企业<br/> 3. 若调用失败或超时，可以使用相同的 out_biz_no 进行幂等重试<br/> 4. 并发使用相同 out_biz_no 调用，会报错：邀请链接生成中<br/> 5. 当企业注册/认证/签约成功后，企业码系统发送的「企业状态变更通知」中，会携带out_biz_no，服务商可用于关联企业ID
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 企业个性化信息，适用于特殊场景，请按需使用
        /// </summary>
        [XmlElement("profiles")]
        public EnterpriseProfilesDTO Profiles { get; set; }

        /// <summary>
        /// 企业注册模式，用于区分接口返回的企业注册页面流程<br/> 不传默认为企业自入驻(NORMAL)
        /// </summary>
        [XmlElement("register_mode")]
        public string RegisterMode { get; set; }

        /// <summary>
        /// 企业注册认证后，需要签约的出资方式；<br/> 不传默认为企业余额出资(BALANCE)
        /// </summary>
        [XmlElement("sign_fund_way")]
        public string SignFundWay { get; set; }
    }
}
