using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundJointaccountOperationApproveModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundJointaccountOperationApproveModel : AopObject
    {
        /// <summary>
        /// 合花群ID<br> 补充说明：<br> - 该字段可在签约接口调用后，由alipay.fund.jointaccount.account.completed通知中返回 <br> - 该字段可在签约接口调用后，由alipay.fund.jointaccount.detail.query中返回
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 授权协议号 <br> 补充说明：<br> - 该字段可在签约接口调用后，由alipay.fund.jointaccount.account.completed通知中返回 <br> - 该字段可在签约接口调用后，由alipay.fund.jointaccount.detail.query中返回
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 审批金额（单位为元，必须大于0且最多小数点后两位）<br> 补充说明：<br> 1.  INVITE_REPLY场景时，该字段无需传递 <br> 2. WITHDRAW_APPROVE场景时，该字段必传:<br> - 该字段可在提现申请接口调用后，alipay.fund.jointaccount.fund.completed中返回 <br> - 该字段可在提现申请接口调用后，由alipay.fund.jointaccount.fund.order.query中返回
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 审批场景<br> - INVITE_REPLY：成员邀请回复<br> - WITHDRAW_APPROVE：提现审批
        /// </summary>
        [XmlElement("approve_scene")]
        public string ApproveScene { get; set; }

        /// <summary>
        /// 业务场景， 目前支持：<br> - LIANAIJI_INVITE_REPLY: 邀请回复场景 <br> - LIANAIJI_WITHDRAW_APPROVE: 提现审批场景
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 审批人用户唯一标识
        /// </summary>
        [XmlElement("identity")]
        public string Identity { get; set; }

        /// <summary>
        /// 审批人账号类型，参考值如下：<br> - OUT_USER_ID：商户侧用户唯一标识(仅支持在邀请回复场景传入该值) <br> - ALIPAY_USER_ID：支付宝侧用户唯一标识
        /// </summary>
        [XmlElement("identity_type")]
        public string IdentityType { get; set; }

        /// <summary>
        /// 审批单号（幂等字段）<br> 补充说明：幂等逻辑（process_id），商户集成时需注意，如换号重复发起，则认为是一笔新的请求<br> - 该字段可在签约接口调用后，由alipay.fund.jointaccount.invite.completed或alipay.fund.jointaccount.fund.completed中返回<br> - 该字段可在签约接口调用后，由alipay.fund.jointaccount.detail.query或alipay.fund.jointaccount.fund.order.query中返回
        /// </summary>
        [XmlElement("process_id")]
        public string ProcessId { get; set; }

        /// <summary>
        /// 销售产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }
    }
}
