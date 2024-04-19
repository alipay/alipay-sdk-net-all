using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceOperationBsEnrollableplanQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceOperationBsEnrollableplanQueryModel : AopObject
    {
        /// <summary>
        /// 联营报名渠道，请咨询产品提供方
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 过滤条件：联营计划的商家权益类型。 为空则查询全部类型。
        /// </summary>
        [XmlArray("merchant_benefit_types")]
        [XmlArrayItem("string")]
        public List<string> MerchantBenefitTypes { get; set; }

        /// <summary>
        /// 分页查询页码，默认1，从1开始
        /// </summary>
        [XmlElement("page_index")]
        public long PageIndex { get; set; }

        /// <summary>
        /// 分页大小，最大20，默认10
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 搜索条件，联营计划名称
        /// </summary>
        [XmlElement("plan_name")]
        public string PlanName { get; set; }

        /// <summary>
        /// 查询可报名的联营计划方案编码
        /// </summary>
        [XmlElement("solution_code")]
        public string SolutionCode { get; set; }
    }
}
