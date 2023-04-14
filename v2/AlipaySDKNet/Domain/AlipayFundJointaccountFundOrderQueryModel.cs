using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundJointaccountFundOrderQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundJointaccountFundOrderQueryModel : AopObject
    {
        /// <summary>
        /// 合花群ID <br/> 补充说明： <br/> - 该字段可在签约接口调用后，由alipay.fund.jointaccount.account.completed中返回<br> - 该字段可在签约接口调用后,由alipay.fund.jointaccount.detail.query中返回
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 授权协议号 <br/> 补充说明： <br/> - 该字段可在签约接口调用后，由alipay.fund.jointaccount.account.completed中返回<br> - 该字段可在签约接口调用后， 由alipay.fund.jointaccount.detail.query中返回
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 业务场景码
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 支付宝侧转账订单号（查询方式一：通过传入 biz_trans_id查询） <br/> 补充说明： <br/> - 该字段可在调用alipay.fund.jointaccount.fund.btoc.transfer中同步返回 <br/> - 该字段可在资金操作接口调用后，由alipay.fund.jointaccount.fund.completed中返回
        /// </summary>
        [XmlElement("biz_trans_id")]
        public string BizTransId { get; set; }

        /// <summary>
        /// 业务渠道</br> 补充说明：</br> 需要商户侧必传，支付宝侧不做强校验
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 发起人）支付宝侧用户唯一标识 补充说明： - 发起人可为C端用户 - 发起人也可为B端商户
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 资金操作类型：<br/> - FREEZE：提现申请 <br/> - UNFREEZE：提现审批拒绝 <br/> - WITHDRAW：提现审批同意 <br/> - DEPOSIT：手动转入 <br/> - SINGLE_TRANSFER：存量资金搬迁
        /// </summary>
        [XmlElement("operate_type")]
        public string OperateType { get; set; }

        /// <summary>
        /// 商户侧单号（查询方式二：通过传入 out_biz_no查询） <br/> 补充说明： <br/> - 该字段与各类资金操作接口的请求参数中传入值保持一致
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 销售产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// （发起人）支付宝侧用户唯一标识 <br/> 补充说明： <br/> - 发起人可为C端用户<br/> - 发起人也可为B端商户
        /// </summary>
        [XmlElement("request_uid")]
        public string RequestUid { get; set; }
    }
}
