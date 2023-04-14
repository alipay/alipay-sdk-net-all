using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundJointaccountSignQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundJointaccountSignQueryModel : AopObject
    {
        /// <summary>
        /// 企业签约账户ID,用于外部商户已获取企业签约ID，查询账户状态
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 场景码，联系支付宝分配
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 外部业务号，查询对应账户状态，优先级高于account_id
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 产品码，默认值 ENTERPRISE_PAY
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }
    }
}
