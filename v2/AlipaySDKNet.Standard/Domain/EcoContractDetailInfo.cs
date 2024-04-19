using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EcoContractDetailInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EcoContractDetailInfo : AopObject
    {
        /// <summary>
        /// 该电子借条是否使用了免费的份额，true代表该份使用了免费份额，false代表未使用免费份额
        /// </summary>
        [XmlElement("is_free_portion")]
        public bool IsFreePortion { get; set; }

        /// <summary>
        /// 跳转三方小程序详情页链接
        /// </summary>
        [XmlElement("jump_url")]
        public string JumpUrl { get; set; }

        /// <summary>
        /// 电子借条详细信息扩展字段
        /// </summary>
        [XmlElement("loan_info")]
        public EcoDetailLoanInfo LoanInfo { get; set; }

        /// <summary>
        /// 阵地来源，ALIPAY代表来自于支付宝阵地
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }
    }
}
