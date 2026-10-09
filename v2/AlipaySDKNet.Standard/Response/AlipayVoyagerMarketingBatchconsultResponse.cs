using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayVoyagerMarketingBatchconsultResponse.
    /// </summary>
    public class AlipayVoyagerMarketingBatchconsultResponse : AopResponse
    {
        /// <summary>
        /// 最优的优惠列表
        /// </summary>
        [XmlElement("best_benefit_list")]
        public BenefitDisplayVO BestBenefitList { get; set; }

        /// <summary>
        /// 业务结果信息
        /// </summary>
        [XmlElement("result")]
        public ResultInfoDTO Result { get; set; }
    }
}
