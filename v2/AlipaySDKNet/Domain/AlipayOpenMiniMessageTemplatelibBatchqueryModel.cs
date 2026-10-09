using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniMessageTemplatelibBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniMessageTemplatelibBatchqueryModel : AopObject
    {
        /// <summary>
        /// 若需要查询带push的消息模板则传true，否则传false
        /// </summary>
        [XmlElement("has_push")]
        public bool HasPush { get; set; }

        /// <summary>
        /// 一级行业类目，以XS开头的行业编码。
        /// </summary>
        [XmlElement("industry_code")]
        public string IndustryCode { get; set; }

        /// <summary>
        /// 归属于行业类目下的行业场景
        /// </summary>
        [XmlElement("industry_scenario")]
        public string IndustryScenario { get; set; }

        /// <summary>
        /// 分页查询参数，分页页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 分页查询参数，分页大小，规定最大分页大小为10
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 可选两种类型，长期性订阅传long_term_subscribe，一次性订阅传one_time_subscribe
        /// </summary>
        [XmlElement("scene_rule")]
        public string SceneRule { get; set; }
    }
}
