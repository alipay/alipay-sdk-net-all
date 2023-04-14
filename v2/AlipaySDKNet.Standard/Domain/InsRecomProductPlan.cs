using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InsRecomProductPlan Data Structure.
    /// </summary>
    [Serializable]
    public class InsRecomProductPlan : AopObject
    {
        /// <summary>
        /// 续期缴费频率。 01 一次性缴费, 02 按月缴费, 03 按年缴费, 04 不定期缴费 05 按日趸交（费用：保费*天数）
        /// </summary>
        [XmlElement("continuous_frequency")]
        public string ContinuousFrequency { get; set; }

        /// <summary>
        /// 保司机构ID
        /// </summary>
        [XmlElement("insurance_id")]
        public string InsuranceId { get; set; }

        /// <summary>
        /// 保司机构名称
        /// </summary>
        [XmlElement("insurance_name")]
        public string InsuranceName { get; set; }

        /// <summary>
        /// 产品名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 支持的保障期限列表(以逗号分隔)
        /// </summary>
        [XmlElement("period")]
        public string Period { get; set; }

        /// <summary>
        /// 参考保费。单位：分
        /// </summary>
        [XmlElement("premium")]
        public long Premium { get; set; }

        /// <summary>
        /// 机构产品名称
        /// </summary>
        [XmlElement("prod_name")]
        public string ProdName { get; set; }

        /// <summary>
        /// 机构产品码
        /// </summary>
        [XmlElement("prod_no")]
        public string ProdNo { get; set; }

        /// <summary>
        /// 机构产品版本
        /// </summary>
        [XmlElement("prod_version")]
        public string ProdVersion { get; set; }

        /// <summary>
        /// 产品标识符
        /// </summary>
        [XmlElement("product_id")]
        public string ProductId { get; set; }

        /// <summary>
        /// 产品方案ID
        /// </summary>
        [XmlElement("product_plan_id")]
        public string ProductPlanId { get; set; }

        /// <summary>
        /// 推荐流水号
        /// </summary>
        [XmlElement("recom_flow_no")]
        public string RecomFlowNo { get; set; }

        /// <summary>
        /// 产品资源项列表
        /// </summary>
        [XmlArray("resource_list")]
        [XmlArrayItem("ins_prod_resource")]
        public List<InsProdResource> ResourceList { get; set; }

        /// <summary>
        /// 销售计划编号
        /// </summary>
        [XmlElement("sale_plan_no")]
        public string SalePlanNo { get; set; }

        /// <summary>
        /// 保额,单位：分
        /// </summary>
        [XmlElement("sum_insured")]
        public long SumInsured { get; set; }
    }
}
