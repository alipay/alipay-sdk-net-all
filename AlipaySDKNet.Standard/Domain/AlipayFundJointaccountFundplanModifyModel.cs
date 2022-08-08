using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundJointaccountFundplanModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundJointaccountFundplanModifyModel : AopObject
    {
        /// <summary>
        /// 账户ID</br> 补充说明：</br> - 该字段可在签约接口alipay.fund.jointaccount.sign调用后，由账户变更通知alipay.fund.jointaccount.account.completed返回</br> - 该字段可在签约alipay.fund.jointaccount.sign接口调用后，商户侧查询账户详情alipay.fund.jointaccount.detail.query接口返回
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 授权协议号</br> 补充说明：</br> -该字段可在签约接口alipay.fund.jointaccount.sign调用后，由账户变更结果通知接口alipay.fund.jointaccount.account.completed中返回。</br> -该字段可在签约接口调用后，商户侧查询账户详情接口alipay.fund.jointaccount.detail.query中返回
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 业务场景码
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 业务渠道</br> 补充说明：</br> 需要商户侧必传，支付宝侧不做强校验
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 自动赞计划计划ID：</br>当前账户自动攒计划唯一标识</br> 补充说明：</br> - 该字段可在签约接口alipay.fund.jointaccount.sign调用后（开户并自动攒场景），由自动攒变更结果通知alipay.fund.jointaccount.fundplan.completed返回</br> - 该字段可在签约接口alipay.fund.jointaccount.sign接口调用后（开户并自动攒场景），商户侧查询自动攒列表alipay.fund.jointaccount.depositplan.list.query返回
        /// </summary>
        [XmlElement("fund_plan_id")]
        public string FundPlanId { get; set; }

        /// <summary>
        /// （发起人）用户唯一标识
        /// </summary>
        [XmlElement("identity")]
        public string Identity { get; set; }

        /// <summary>
        /// （发起人）账号类型，参考值如下：</br> -ALIPAY_USER_ID：支付宝侧用户唯一标识
        /// </summary>
        [XmlElement("identity_type")]
        public string IdentityType { get; set; }

        /// <summary>
        /// 操作类型：</br> - PAUSE：暂停 </br> - DELETE：删除</br>
        /// </summary>
        [XmlElement("operation_type")]
        public string OperationType { get; set; }

        /// <summary>
        /// 销售产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }
    }
}
