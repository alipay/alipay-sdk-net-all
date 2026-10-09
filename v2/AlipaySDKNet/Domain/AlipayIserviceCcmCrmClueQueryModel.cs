using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceCcmCrmClueQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceCcmCrmClueQueryModel : AopObject
    {
        /// <summary>
        /// 有三个字段field_code，field_operator_type，value，field_code：字段名 field_operator_type：查询条件 value:查询的值
        /// </summary>
        [XmlArray("condition")]
        [XmlArrayItem("alipay_condition")]
        public List<AlipayCondition> Condition { get; set; }

        /// <summary>
        /// 当前页码，可选参数，不选默认值为:1
        /// </summary>
        [XmlElement("current_page")]
        public long CurrentPage { get; set; }

        /// <summary>
        /// 查询参数条件，可选
        /// </summary>
        [XmlElement("obj_code")]
        public string ObjCode { get; set; }

        /// <summary>
        /// 页大小，可选，默认:10
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 租户实例id，必填，智能拓客平台分配
        /// </summary>
        [XmlElement("tenant_id")]
        public string TenantId { get; set; }
    }
}
