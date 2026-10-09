using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MybankCreditLoantradePayeeArConsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankCreditLoantradePayeeArConsultModel : AopObject
    {
        /// <summary>
        /// 签约业务场景，网商指定
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 签约业务子场景，网商指定，可选
        /// </summary>
        [XmlElement("sub_biz_scene")]
        public string SubBizScene { get; set; }

        /// <summary>
        /// 用户信息
        /// </summary>
        [XmlElement("user_info")]
        public CreditPayUserVO UserInfo { get; set; }
    }
}
