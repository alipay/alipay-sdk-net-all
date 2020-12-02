using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MybankCreditLoantradePayOrderQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankCreditLoantradePayOrderQueryModel : AopObject
    {
        /// <summary>
        /// 支付宝UID
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 场景码
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 子场景
        /// </summary>
        [XmlElement("sub_biz_scene")]
        public string SubBizScene { get; set; }
    }
}
