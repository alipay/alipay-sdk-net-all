using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundJointaccountFundApplyWithdrawModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundJointaccountFundApplyWithdrawModel : AopObject
    {
        /// <summary>
        /// 合花群ID<br> 补充说明：<br> 1. 该字段可在签约接口调用后，由alipay.fund. jointaccount.account.completed返回<br> 2. 该字段可在签约接口调用后，由alipay.fund. jointaccount.detail.query返回<br>
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 授权协议号<br> 补充说明：<br> 1. 该字段可在签约接口调用后，由alipay.fund. jointaccount.account.completed返回<br> 2. 该字段可在签约接口调用后，由alipay.fund. jointaccount.detail.query返回
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 提现金额（单位为元，必须大于0且最多小数点后两位）
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// （审批人）支付宝侧用户唯一标识列表<br> 补充说明：审批人列表最多包括8个审批人，且唯一标识必须为支付宝侧用户唯一标识<br> 1. 该字段可群成员接受邀请后，由alipay.fund. jointaccount.member.completed返回<br> 2. 该字段可在签约接口调用后，由alipay.fund. jointaccount.detail.query返回
        /// </summary>
        [XmlArray("auditors")]
        [XmlArrayItem("string")]
        public List<string> Auditors { get; set; }

        /// <summary>
        /// 业务场景
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// （发起人）用户唯一标识
        /// </summary>
        [XmlElement("identity")]
        public string Identity { get; set; }

        /// <summary>
        /// （发起人）账号类型，参考值如下：<br> ALIPAY_USER_ID：支付宝侧用户唯一标识
        /// </summary>
        [XmlElement("identity_type")]
        public string IdentityType { get; set; }

        /// <summary>
        /// 商户侧单号（幂等字段）<br>     补充说明：幂等逻辑（商户appid+out_biz_no），商户集成时需注意，如换号重复发起，则认为是一笔新的请求
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 提现申请倒计时（单位：秒），超时后撤销系统自动撤销提现申请<br> 补充说明：<br> 1. 商户传递时，最长不可超过999999秒（约11天）<br> 2. 商户不传该字段时，支付宝默认申请72小时后发起撤销操作
        /// </summary>
        [XmlElement("pay_timeout")]
        public string PayTimeout { get; set; }

        /// <summary>
        /// 销售产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }
    }
}
