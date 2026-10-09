using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsSceneApplicationOutsideApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsSceneApplicationOutsideApplyModel : AopObject
    {
        /// <summary>
        /// 保险干系人
        /// </summary>
        [XmlElement("applicant")]
        public InsPerson Applicant { get; set; }

        /// <summary>
        /// 业务因子信息
        /// </summary>
        [XmlElement("biz_factor")]
        public string BizFactor { get; set; }

        /// <summary>
        /// 保险止期
        /// </summary>
        [XmlElement("effect_end_time")]
        public string EffectEndTime { get; set; }

        /// <summary>
        /// 生效日期
        /// </summary>
        [XmlElement("effect_start_time")]
        public string EffectStartTime { get; set; }

        /// <summary>
        /// 被保人信息
        /// </summary>
        [XmlArray("insureds")]
        [XmlArrayItem("ins_person")]
        public List<InsPerson> Insureds { get; set; }

        /// <summary>
        /// 外部业务号(幂等字段)
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 险种保障期限,数字+"Y/M/D"结尾,非固定期限险种或多固定期限险种必填
        /// </summary>
        [XmlElement("period")]
        public string Period { get; set; }

        /// <summary>
        /// 保费信息，一口价场景可以为空，定价规则较为复杂场景需外部传入用于业务核价，单位(分)
        /// </summary>
        [XmlElement("premium")]
        public long Premium { get; set; }

        /// <summary>
        /// 产品号
        /// </summary>
        [XmlElement("prod_code")]
        public string ProdCode { get; set; }

        /// <summary>
        /// 来源
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 保额(单位:分)，可选
        /// </summary>
        [XmlElement("sum_insured")]
        public long SumInsured { get; set; }
    }
}
