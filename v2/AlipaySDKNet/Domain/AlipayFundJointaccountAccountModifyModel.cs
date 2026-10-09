using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundJointaccountAccountModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundJointaccountAccountModifyModel : AopObject
    {
        /// <summary>
        /// 账户ID</br> 补充说明：</br> - 该字段可在签约接口alipay.fund.jointaccount.sign调用后， 账户变更结果通知alipay.fund.jointaccount.account.completed中返回</br> - 该字段可在签约接口alipay.fund.jointaccount.sign调用后，由查询账户详情alipay.fund.jointaccount.detail.query中返回
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 授权协议号</br> 补充说明：</br> - 该字段可在签约接口alipay.fund.jointaccount.sign调用后， 账户变更结果通知alipay.fund.jointaccount.account.completed中返回</br> - 该字段可在签约接口alipay.fund.jointaccount.sign调用后，由查询账户详情alipay.fund.jointaccount.detail.query中返回
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
        /// （发起人）用户唯一标识
        /// </summary>
        [XmlElement("identity")]
        public string Identity { get; set; }

        /// <summary>
        /// （发起人）账号类型，参考值如下</br> ALIPAY_USER_ID：支付宝侧用户唯一标识
        /// </summary>
        [XmlElement("identity_type")]
        public string IdentityType { get; set; }

        /// <summary>
        /// 新账户名称</br> - 格式</br> {"entity_name":"记账"}</br> - key必须为：entity_name</br> - 如出现敏感字、长度超长则修改失败，可包括数字、字母、空格、汉字，特殊字符、emoji等
        /// </summary>
        [XmlElement("modify_items")]
        public string ModifyItems { get; set; }

        /// <summary>
        /// （发起人）支付宝侧用户唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 销售产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }
    }
}
