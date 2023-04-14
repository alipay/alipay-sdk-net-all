using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundJointaccountFundallocListQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundJointaccountFundallocListQueryModel : AopObject
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
        /// 当前合花群中的自动攒计划唯一标识<br> 补充说明：<br> - 该字段可新增自动攒计划后，由alipay.fund.jointaccount.depositplan.list.query中返回
        /// </summary>
        [XmlElement("fund_plan_id")]
        public string FundPlanId { get; set; }

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
        /// 自动攒计划的调拨记录的起始标识（游标分页法）<br> 补充说明：<br> - 查询第一页时，可传空<br> - 点击下一页查询时，可传递上一次查询所返回的last_id
        /// </summary>
        [XmlElement("last_id")]
        public string LastId { get; set; }

        /// <summary>
        /// （发起人）用户唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 从起始标识往后查询多少条调拨记录<br> 补充说明：<br> - 该字段不传时，支付宝侧默认查询20条<br> - 超过20时按20条查询<br> - 剩余记录数不足20条则按实际记录数返回
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 销售产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 自动攒计划的调拨记录的执行结果（查询过滤条件）<br> - SUCCESS：执行成功<br> - FAIL：执行失败<br> - NO_PROCESS：未执行（如指定付款方资产的可用金额试算不足以完成扣款）
        /// </summary>
        [XmlArray("status_list")]
        [XmlArrayItem("string")]
        public List<string> StatusList { get; set; }
    }
}
