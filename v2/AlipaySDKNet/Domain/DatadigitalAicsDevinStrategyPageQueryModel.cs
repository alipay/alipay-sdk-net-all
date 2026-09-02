using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DatadigitalAicsDevinStrategyPageQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class DatadigitalAicsDevinStrategyPageQueryModel : AopObject
    {
        /// <summary>
        /// 条件连接类型枚举，可选（控制 search_fields 之间的逻辑关系）。注意：当前底层 buildQueryRequest 未消费该字段，已预留。可选值：must(且关系)、must_not(且与非关系)、should(或关系)
        /// </summary>
        [XmlElement("condition_join_type_enum")]
        public string ConditionJoinTypeEnum { get; set; }

        /// <summary>
        /// CRM线索开关枚举，可选（控制是否展示已转化线索）。注意：当前底层 buildQueryRequest 未消费该字段，已预留。可选值：OPEN(开启)、CLOSE(关闭)
        /// </summary>
        [XmlElement("crm_cue_open_enum")]
        public string CrmCueOpenEnum { get; set; }

        /// <summary>
        /// CRM查询类型枚举，可选（控制查询范围）。注意：当前底层 buildQueryRequest 未消费该字段，已预留。可选值：JOIN(我参与的)、OWNER(我负责的)、ASSIGN(分配给我的)、RELATION(我是相关人)、PUBLIC(公海的)、ALL(全部)
        /// </summary>
        [XmlElement("crm_query_type_enum")]
        public string CrmQueryTypeEnum { get; set; }

        /// <summary>
        /// 当前页码，默认1
        /// </summary>
        [XmlElement("current")]
        public long Current { get; set; }

        /// <summary>
        /// 表单编码，固定值 WORK（底层处理器 checkRequest 校验非空，buildQueryRequest 强制使用 WORK，对客传值被忽略）
        /// </summary>
        [XmlElement("form_code")]
        public string FormCode { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("global_search_field_list")]
        [XmlArrayItem("string")]
        public List<string> GlobalSearchFieldList { get; set; }

        /// <summary>
        /// 是否只查已跟进数据，默认false
        /// </summary>
        [XmlElement("has_followed")]
        public bool HasFollowed { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("must_exist_fields")]
        [XmlArrayItem("string")]
        public List<string> MustExistFields { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("must_not_exist_fields")]
        [XmlArrayItem("string")]
        public List<string> MustNotExistFields { get; set; }

        /// <summary>
        /// 是否对返回字段做脱敏，默认false
        /// </summary>
        [XmlElement("need_mask_field")]
        public bool NeedMaskField { get; set; }

        /// <summary>
        /// 是否使用新数据格式返回，默认false
        /// </summary>
        [XmlElement("new_data_format")]
        public bool NewDataFormat { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("or_not_empty_fields")]
        [XmlArrayItem("string")]
        public List<string> OrNotEmptyFields { get; set; }

        /// <summary>
        /// 归属人工号，可选（按归属人过滤）
        /// </summary>
        [XmlElement("owner")]
        public string Owner { get; set; }

        /// <summary>
        /// 每页条数，默认20，最大100
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("recall_field_list")]
        [XmlArrayItem("string")]
        public List<string> RecallFieldList { get; set; }

        /// <summary>
        /// 搜索字段列表（全部需匹配，AND 关系），可选。平台可映射为服务端驼峰字段
        /// </summary>
        [XmlElement("search_fields")]
        public SearchField SearchFields { get; set; }

        /// <summary>
        /// 全局搜索单词，可选
        /// </summary>
        [XmlElement("search_keyword")]
        public string SearchKeyword { get; set; }

        /// <summary>
        /// 搜索字段列表（满足其一即可，OR 关系），可选。平台可映射为服务端驼峰字段
        /// </summary>
        [XmlElement("search_should_fields")]
        public SearchField SearchShouldFields { get; set; }

        /// <summary>
        /// 排序字段列表，可选。平台可映射为服务端驼峰字段
        /// </summary>
        [XmlElement("sort_fields")]
        public SortField SortFields { get; set; }

        /// <summary>
        /// 租户ID，长度8-32位
        /// </summary>
        [XmlElement("tenant_id")]
        public string TenantId { get; set; }
    }
}
