using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundJointaccountFundBtocTransferModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundJointaccountFundBtocTransferModel : AopObject
    {
        /// <summary>
        /// 合花群ID<br> 补充说明：<br> - 该字段可在签约接口调用后，由alipay.fund.jointaccount.account.completed中返回 <br> - 该字段可在签约接口调用后，由alipay.fund.jointaccount.detail.query中返回
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 授权协议号<br> 补充说明：<br> - 该字段可在签约接口调用后，由alipay.fund.jointaccount.account.completed中返回 <br> - 该字段可在签约接口调用后， 由alipay.fund.jointaccount.detail.query中返回
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 业务场景
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 订单标题，长度超长会拒绝交易，可包括数字、字母、空格、汉字，但不能包括特殊字符、emoji等
        /// </summary>
        [XmlElement("order_title")]
        public string OrderTitle { get; set; }

        /// <summary>
        /// 商户侧单号（幂等字段）<br/> 补充说明： 幂等逻辑（商户appid+out_biz_no），商户集成时需注意，如换号重复发起，则认为是一笔新的请求
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 销售产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 订单备注，长度超长会拒绝交易，可包括数字、字母、空格、汉字，但不能包括特殊字符、emoji等
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 转入金额（单位为元，必须大于0且最多小数点后两位，最大金额不超过100万）
        /// </summary>
        [XmlElement("trans_amount")]
        public string TransAmount { get; set; }
    }
}
