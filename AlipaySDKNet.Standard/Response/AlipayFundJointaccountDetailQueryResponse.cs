using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundJointaccountDetailQueryResponse.
    /// </summary>
    public class AlipayFundJointaccountDetailQueryResponse : AopResponse
    {
        /// <summary>
        /// 合花群ID（支付宝侧生成）
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 账户名称（支付宝侧生成）
        /// </summary>
        [XmlElement("account_name")]
        public string AccountName { get; set; }

        /// <summary>
        /// 额度模型
        /// </summary>
        [XmlArray("account_quota")]
        [XmlArrayItem("joint_account_quota_resp_d_t_o")]
        public List<JointAccountQuotaRespDTO> AccountQuota { get; set; }

        /// <summary>
        /// 账户状态<br> -NORMAL：正常<br> -RELEASING：注销中<br> -RELEASED：已注销<br> - FREEZE：冻结
        /// </summary>
        [XmlElement("account_status")]
        public string AccountStatus { get; set; }

        /// <summary>
        /// 授权协议号（支付宝侧生成）
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 交易授权信息 指定收单商户
        /// </summary>
        [XmlElement("authorized_rule")]
        public AuthorizedRuleDTO AuthorizedRule { get; set; }

        /// <summary>
        /// 当前可用金额（单位为元，必须大于0且最多小数点后两位）
        /// </summary>
        [XmlElement("available_balance")]
        public string AvailableBalance { get; set; }

        /// <summary>
        /// 业务场景码
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// （创建人）支付宝侧用户唯一标识
        /// </summary>
        [XmlElement("creator_id")]
        public string CreatorId { get; set; }

        /// <summary>
        /// （创建人）支付宝侧用户唯一标识
        /// </summary>
        [XmlElement("creator_open_id")]
        public string CreatorOpenId { get; set; }

        /// <summary>
        /// （创建人）商户侧用户唯一标识<br> 补充说明：<br> -如果签约时，发起人标识传递的是商户侧用户唯一标识，则该字段会返回<br> -如果签约时，发起人标识传递的是支付宝侧用户唯一标识，则该字段为空
        /// </summary>
        [XmlElement("creator_out_id")]
        public string CreatorOutId { get; set; }

        /// <summary>
        /// 当前冻结金额（单位为元，必须大于0且最多小数点后两位）
        /// </summary>
        [XmlElement("freeze_balance")]
        public string FreezeBalance { get; set; }

        /// <summary>
        /// 签约时邀请的成员列表（快照）
        /// </summary>
        [XmlArray("invite_result_list")]
        [XmlArrayItem("invite_result_d_t_o")]
        public List<InviteResultDTO> InviteResultList { get; set; }

        /// <summary>
        /// 已加入合花群的成员列表
        /// </summary>
        [XmlArray("member_list")]
        [XmlArrayItem("joint_account_member_info_resp_d_t_o")]
        public List<JointAccountMemberInfoRespDTO> MemberList { get; set; }

        /// <summary>
        /// 销售产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 生息状态：</br> - MAKING    ：开启中</br> - MADE.       ：已开启</br> - CLEARING：关闭中</br> - NONE.       ：未生息
        /// </summary>
        [XmlElement("profit_status")]
        public string ProfitStatus { get; set; }

        /// <summary>
        /// 昨日收益
        /// </summary>
        [XmlElement("yesterday_profit")]
        public string YesterdayProfit { get; set; }
    }
}
