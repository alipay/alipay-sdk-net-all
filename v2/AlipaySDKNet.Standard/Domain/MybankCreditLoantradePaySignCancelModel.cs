using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MybankCreditLoantradePaySignCancelModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankCreditLoantradePaySignCancelModel : AopObject
    {
        /// <summary>
        /// 支付宝ID
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 业务场景
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 站点
        /// </summary>
        [XmlElement("site")]
        public string Site { get; set; }

        /// <summary>
        /// 站点用户ID
        /// </summary>
        [XmlElement("site_user_id")]
        public string SiteUserId { get; set; }

        /// <summary>
        /// 子业务场景
        /// </summary>
        [XmlElement("sub_biz_scene")]
        public string SubBizScene { get; set; }
    }
}
