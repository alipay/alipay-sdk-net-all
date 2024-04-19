using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DatadigitalFincloudFinsaasInsuranceInstanceruleSaveModel Data Structure.
    /// </summary>
    [Serializable]
    public class DatadigitalFincloudFinsaasInsuranceInstanceruleSaveModel : AopObject
    {
        /// <summary>
        /// 实例id
        /// </summary>
        [XmlElement("instance_id")]
        public string InstanceId { get; set; }

        /// <summary>
        /// 外部租户id
        /// </summary>
        [XmlElement("out_tenant_id")]
        public string OutTenantId { get; set; }

        /// <summary>
        /// 外部产品id
        /// </summary>
        [XmlElement("outer_product_id")]
        public string OuterProductId { get; set; }

        /// <summary>
        /// 规则列表
        /// </summary>
        [XmlArray("rule_items")]
        [XmlArrayItem("rule_v_o")]
        public List<RuleVO> RuleItems { get; set; }
    }
}
