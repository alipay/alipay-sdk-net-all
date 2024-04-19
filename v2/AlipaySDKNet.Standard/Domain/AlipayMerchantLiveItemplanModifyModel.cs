using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantLiveItemplanModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantLiveItemplanModifyModel : AopObject
    {
        /// <summary>
        /// 投放内容，数组，内容为具体条目
        /// </summary>
        [XmlArray("content")]
        [XmlArrayItem("item_plan_content_d_o")]
        public List<ItemPlanContentDO> Content { get; set; }

        /// <summary>
        /// 可空，计划截止时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 针对投放内容的操作， 包含3种类型： 覆盖:OVERRIDE  追加:APPEND  删除:DELETE
        /// </summary>
        [XmlElement("op_type")]
        public string OpType { get; set; }

        /// <summary>
        /// 投放方标识，一般为小程序id
        /// </summary>
        [XmlElement("operator_appid")]
        public string OperatorAppid { get; set; }

        /// <summary>
        /// 投放方类型，生活号：LIFE_APP 达人：CONTENT_USER 小程序：TINYAPP
        /// </summary>
        [XmlElement("operator_type")]
        public string OperatorType { get; set; }

        /// <summary>
        /// 投放计划名，可空
        /// </summary>
        [XmlElement("plan_name")]
        public string PlanName { get; set; }

        /// <summary>
        /// 可空，计划生效时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 计划状态 0待生效 1生效中 -1已作废
        /// </summary>
        [XmlElement("status")]
        public long Status { get; set; }

        /// <summary>
        /// 投放目标，一般为生活号id，多个逗号隔开
        /// </summary>
        [XmlElement("target_id")]
        public string TargetId { get; set; }

        /// <summary>
        /// 投放范围， 指主体内的具体子渠道，为空则任意子渠道
        /// </summary>
        [XmlElement("target_range")]
        public string TargetRange { get; set; }

        /// <summary>
        /// 投放目标类型 生活号：LIFE_APP  达人：CONTENT_USER  小程序:TINYAPP
        /// </summary>
        [XmlElement("target_type")]
        public string TargetType { get; set; }
    }
}
