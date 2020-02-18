using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsSceneHealthGiftQueryResponse.
    /// </summary>
    public class AlipayInsSceneHealthGiftQueryResponse : AopResponse
    {
        /// <summary>
        /// 赠险是否已开通，true标识已开通，false标识未开通
        /// </summary>
        [XmlElement("already_open")]
        public bool AlreadyOpen { get; set; }

        /// <summary>
        /// 返回当前可领取保额的赠险类型。HEALTH_BEAN_SIMPLE_UPGRADE表示免费医疗金
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 可领取的保额
        /// </summary>
        [XmlElement("delta_sum_insured")]
        public string DeltaSumInsured { get; set; }

        /// <summary>
        /// 某渠道已领取保额
        /// </summary>
        [XmlElement("source_gained_sum_insured")]
        public string SourceGainedSumInsured { get; set; }

        /// <summary>
        /// 当前在保保额
        /// </summary>
        [XmlElement("sum_insured")]
        public string SumInsured { get; set; }
    }
}
