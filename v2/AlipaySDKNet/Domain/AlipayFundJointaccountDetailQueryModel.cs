using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundJointaccountDetailQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundJointaccountDetailQueryModel : AopObject
    {
        /// <summary>
        /// 合花群ID（查询方式二：通过传入account_id+agreement_no查询）<br> 补充说明：<br> -该字段可在签约接口alipay.fund.jointaccount.sign调用后，由账户变更结果通知接口alipay.fund.jointaccount.account.completed中返回。<br> -该字段可在签约接口调用后，由查询账户详情接口alipay.fund.jointaccount.detail.query中返回。
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 授权协议号（查询方式二：通过传入account_id+agreement_no查询）<br> 补充说明：<br> -该字段可在签约接口alipay.fund.jointaccount.sign调用后，由账户变更结果通知接口alipay.fund.jointaccount.account.completed中返回。<br> -该字段可在签约接口调用后，由查询账户详情接口alipay.fund.jointaccount.detail.query中返回。
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
        /// 商户侧单号（查询方式一：通过传入 out_biz_no查询）<br> 补充说明：<br> -该字段与签约接口alipay.fund.jointaccount.sign请求参数中传入值保持一致
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 销售产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }
    }
}
