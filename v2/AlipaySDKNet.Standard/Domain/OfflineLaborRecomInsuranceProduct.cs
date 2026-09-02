using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OfflineLaborRecomInsuranceProduct Data Structure.
    /// </summary>
    [Serializable]
    public class OfflineLaborRecomInsuranceProduct : AopObject
    {
        /// <summary>
        /// 保司ID
        /// </summary>
        [XmlElement("insurance_id")]
        public string InsuranceId { get; set; }

        /// <summary>
        /// 保司名称
        /// </summary>
        [XmlElement("insurance_name")]
        public string InsuranceName { get; set; }

        /// <summary>
        /// 方案名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// "1D"表示1天，xxD表示多少天
        /// </summary>
        [XmlElement("period")]
        public string Period { get; set; }

        /// <summary>
        /// 保费，单位：分
        /// </summary>
        [XmlElement("premium")]
        public long Premium { get; set; }

        /// <summary>
        /// 产品名称，如"众安员工意外险"
        /// </summary>
        [XmlElement("prod_name")]
        public string ProdName { get; set; }

        /// <summary>
        /// 产品编号，后续可用于查询保单列表
        /// </summary>
        [XmlElement("prod_no")]
        public string ProdNo { get; set; }

        /// <summary>
        /// 产品版本
        /// </summary>
        [XmlElement("prod_version")]
        public string ProdVersion { get; set; }

        /// <summary>
        /// 产品编码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 产品id
        /// </summary>
        [XmlElement("product_id")]
        public string ProductId { get; set; }

        /// <summary>
        /// 产品方案ID
        /// </summary>
        [XmlElement("product_plan_id")]
        public string ProductPlanId { get; set; }

        /// <summary>
        /// 推荐产品编号，后续用于投保
        /// </summary>
        [XmlElement("recom_flow_no")]
        public string RecomFlowNo { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("resource_list")]
        [XmlArrayItem("offline_labor_recom_insurance_resource")]
        public List<OfflineLaborRecomInsuranceResource> ResourceList { get; set; }

        /// <summary>
        /// 销售方案编号
        /// </summary>
        [XmlElement("sale_plan_no")]
        public string SalePlanNo { get; set; }

        /// <summary>
        /// 保额，单位：分
        /// </summary>
        [XmlElement("sum_insured")]
        public long SumInsured { get; set; }
    }
}
