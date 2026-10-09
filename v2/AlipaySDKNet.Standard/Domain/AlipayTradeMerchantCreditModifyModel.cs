using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayTradeMerchantCreditModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeMerchantCreditModifyModel : AopObject
    {
        /// <summary>
        /// 标识本次授信拆分的业务场景，具体的值由支付宝定义
        /// </summary>
        [XmlElement("credit_scene")]
        public string CreditScene { get; set; }

        /// <summary>
        /// 当前要修改的信用额度，绝对值  单位为元，精确到小数点后两位，取值范围[0.01,100000000]
        /// </summary>
        [XmlElement("current_credit_quota")]
        public string CurrentCreditQuota { get; set; }

        /// <summary>
        /// 标识商家授信额度的来源，具体的值由支付宝定义
        /// </summary>
        [XmlElement("merchant_credit_source")]
        public string MerchantCreditSource { get; set; }

        /// <summary>
        /// 商户的userId
        /// </summary>
        [XmlElement("merchant_user_id")]
        public string MerchantUserId { get; set; }

        /// <summary>
        /// 外部请求号
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 未修改前的卖家授信分配的额度  单位为元，精确到小数点后两位，取值范围[0.01,100000000]
        /// </summary>
        [XmlElement("previous_credit_quota")]
        public string PreviousCreditQuota { get; set; }
    }
}
