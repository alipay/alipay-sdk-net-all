using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundJointaccountDepositplanListQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundJointaccountDepositplanListQueryModel : AopObject
    {
        /// <summary>
        /// 合花群ID<br> 补充说明：<br> - 该字段可在签约接口调用后，由alipay.fund.jointaccount.account.completed返回<br> - 该字段可在签约接口调用后，由alipay.fund.jointaccount.detail.query接口中返回
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 授权协议号<br> 补充说明：<br> - 该字段可在签约接口调用后，由alipay.fund.jointaccount.account.completed中返回<br> - 该字段可在签约接口调用后，由alipay.fund.jointaccount.detail.query接口中返回
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

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
        /// （发起人）用户唯一标识
        /// </summary>
        [XmlElement("identity")]
        public string Identity { get; set; }

        /// <summary>
        /// （发起人）账号类型，参考值如下<br> - ALIPAY_USER_ID：支付宝侧用户唯一标识
        /// </summary>
        [XmlElement("identity_type")]
        public string IdentityType { get; set; }

        /// <summary>
        /// （发起人）用户唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 外部业务号</br> 商户侧单号（幂等字段） 补充说明：</br> - 该字段由签约接口alipay.fund.jointaccount.sign调用后，由自动攒变更通知alipay.fund.jointaccount.fundplan.completed中返回</br>- 自动攒场景幂等逻辑,如换号重复发起，则认为是一笔新的请求
        /// </summary>
        [XmlArray("out_biz_no_list")]
        [XmlArrayItem("string")]
        public List<string> OutBizNoList { get; set; }

        /// <summary>
        /// 销售产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 查询模式</br> OUT_BIZ_NO_OWNER：根据accountId+outBizNoList查询
        /// </summary>
        [XmlElement("query_mode")]
        public string QueryMode { get; set; }
    }
}
