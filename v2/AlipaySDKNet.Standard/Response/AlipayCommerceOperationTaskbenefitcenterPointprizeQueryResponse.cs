using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceOperationTaskbenefitcenterPointprizeQueryResponse.
    /// </summary>
    public class AlipayCommerceOperationTaskbenefitcenterPointprizeQueryResponse : AopResponse
    {
        /// <summary>
        /// 是否还有更多数据,用于分页加载下一页
        /// </summary>
        [XmlElement("has_more")]
        public bool HasMore { get; set; }

        /// <summary>
        /// 商业化权益列表
        /// </summary>
        [XmlElement("vehowner_benefit_list")]
        public IsvVehownerBenefitVO VehownerBenefitList { get; set; }

        /// <summary>
        /// 券类型奖品列表
        /// </summary>
        [XmlElement("voucher_list")]
        public IsvVoucherVO VoucherList { get; set; }
    }
}
