using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundJointaccountSignModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundJointaccountSignModel : AopObject
    {
        /// <summary>
        /// 账本名称，传空采用默认规则命名，使用公司名称
        /// </summary>
        [XmlElement("account_name")]
        public string AccountName { get; set; }

        /// <summary>
        /// 账户初始额度 未设置额度的账本无法进行支付
        /// </summary>
        [XmlArray("account_quota")]
        [XmlArrayItem("joint_account_quota_d_t_o")]
        public List<JointAccountQuotaDTO> AccountQuota { get; set; }

        /// <summary>
        /// 授权商户列表
        /// </summary>
        [XmlArray("authorized_detail_list")]
        [XmlArrayItem("authorize_detail_d_t_o")]
        public List<AuthorizeDetailDTO> AuthorizedDetailList { get; set; }

        /// <summary>
        /// 交易授权信息 指定收单商户
        /// </summary>
        [XmlElement("authorized_rule")]
        public AuthorizedRuleDTO AuthorizedRule { get; set; }

        /// <summary>
        /// 业务场景
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 业务渠道</br> 补充说明：</br> 需要商户侧必传，支付宝侧不做强校验
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 资金转入计划详情</br> 补充说明：</br> 开户+手动转入场景，必传
        /// </summary>
        [XmlElement("deposit")]
        public DepositForm Deposit { get; set; }

        /// <summary>
        /// 资金计划详情</br> 补充说明：</br>开户+自动攒场景，必传
        /// </summary>
        [XmlElement("fund_plan")]
        public FundPlanForm FundPlan { get; set; }

        /// <summary>
        /// 开户账号：<br> -当identity_type是ALIPAY_USER_ID时填支付宝会员ID（2088开头）<br> -当identity_type是ALIPAY_LOGON_ID 时填支付宝登录号<br> -当identity_type是OUT_USER_ID时填外部平台的用户uid
        /// </summary>
        [XmlElement("identity")]
        public string Identity { get; set; }

        /// <summary>
        /// 账号类型，目前支持如下类型： <br> -ALIPAY_USER_ID 支付宝的会员ID<br> -ALIPAY_LOGON_ID：支付宝登录号，支持邮箱和手机号格式<br> -OUT_USER_ID：外部用户uid，如钉钉侧的钉钉会员uid
        /// </summary>
        [XmlElement("identity_type")]
        public string IdentityType { get; set; }

        /// <summary>
        /// 开户时被邀请者列表
        /// </summary>
        [XmlArray("invitee_list")]
        [XmlArrayItem("invite_member_form")]
        public List<InviteMemberForm> InviteeList { get; set; }

        /// <summary>
        /// 开户用户名称，identity_type为ALIPAY_LOGON_ID时必填
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 开户邀请倒计时（单位：秒），超时后撤销系统自动撤销开户操作。<br> 补充说明：<br> -商户传递时，最长不可超过999999秒（约11天）<br> -商户不传该字段时，支付宝默认开户72小时后发起撤销操作
        /// </summary>
        [XmlElement("open_timeout")]
        public string OpenTimeout { get; set; }

        /// <summary>
        /// 商户侧单号（幂等字段）<br> -补充说明：幂等逻辑（商户appid+out_biz_no），商户集成时需注意，如换号重复发起，则认为是一笔新的请求
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 外部实体ID，一般表述为外部操作人操作某个外部实体。比如企业码2284号
        /// </summary>
        [XmlElement("out_entity_id")]
        public string OutEntityId { get; set; }

        /// <summary>
        /// ISV平台定义的共同账户开户来源
        /// </summary>
        [XmlElement("out_source")]
        public string OutSource { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }
    }
}
