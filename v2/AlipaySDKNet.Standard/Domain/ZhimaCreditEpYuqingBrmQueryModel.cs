using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCreditEpYuqingBrmQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditEpYuqingBrmQueryModel : AopObject
    {
        /// <summary>
        /// Unix 时间戳。查询起始时间（含 begin），精确到秒
        /// </summary>
        [XmlElement("begin")]
        public long Begin { get; set; }

        /// <summary>
        /// 统一社会信用代码号码。当needLabelAgg为true时必填
        /// </summary>
        [XmlElement("crn")]
        public string Crn { get; set; }

        /// <summary>
        /// 文章指纹，此数值相同表示是相似文章，也可通过此字段查询相似文章
        /// </summary>
        [XmlElement("doc_self_content_sign")]
        public string DocSelfContentSign { get; set; }

        /// <summary>
        /// Unix 时间戳。查询截止时间（含 begin），精确到秒
        /// </summary>
        [XmlElement("end")]
        public long End { get; set; }

        /// <summary>
        /// 搜索的实体列表，全词匹配，多个关键字是与的关系
        /// </summary>
        [XmlArray("entities_and")]
        [XmlArrayItem("string")]
        public List<string> EntitiesAnd { get; set; }

        /// <summary>
        /// 搜索的实体列表，全词匹配，多个关键字是与的关系
        /// </summary>
        [XmlArray("entities_or")]
        [XmlArrayItem("string")]
        public List<string> EntitiesOr { get; set; }

        /// <summary>
        /// 新闻唯一id，多个id是或的关系
        /// </summary>
        [XmlArray("ids")]
        [XmlArrayItem("string")]
        public List<string> Ids { get; set; }

        /// <summary>
        /// 按关键字搜索，在文章标题和searchableText中搜索，多个关键字是与的关系
        /// </summary>
        [XmlArray("keywords_and")]
        [XmlArrayItem("string")]
        public List<string> KeywordsAnd { get; set; }

        /// <summary>
        /// 按关键字搜索，在文章标题和searchableText中搜索，多个关键字是或的关系
        /// </summary>
        [XmlArray("keywords_or")]
        [XmlArrayItem("string")]
        public List<string> KeywordsOr { get; set; }

        /// <summary>
        /// 标签关键字，多个标签是或的关系
        /// </summary>
        [XmlArray("labels")]
        [XmlArrayItem("string")]
        public List<string> Labels { get; set; }

        /// <summary>
        /// 是否需要对实体进行聚合
        /// </summary>
        [XmlElement("need_entity_agg")]
        public bool NeedEntityAgg { get; set; }

        /// <summary>
        /// 是否需要对标签进行聚合
        /// </summary>
        [XmlElement("need_label_agg")]
        public bool NeedLabelAgg { get; set; }

        /// <summary>
        /// 从第几页开始返回，默认0
        /// </summary>
        [XmlElement("page")]
        public string Page { get; set; }

        /// <summary>
        /// 单次返回的数据数量
        /// </summary>
        [XmlElement("size")]
        public long Size { get; set; }

        /// <summary>
        /// 是否使用updateTime作为时间筛选依据。true:使用updateTime筛选，false：使用pubTime筛选
        /// </summary>
        [XmlElement("use_update_time")]
        public bool UseUpdateTime { get; set; }
    }
}
