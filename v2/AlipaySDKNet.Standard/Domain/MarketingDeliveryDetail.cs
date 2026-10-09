using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MarketingDeliveryDetail Data Structure.
    /// </summary>
    [Serializable]
    public class MarketingDeliveryDetail : AopObject
    {
        /// <summary>
        /// 投放详情绑定的模板id列表
        /// </summary>
        [XmlArray("bind_id_list")]
        [XmlArrayItem("string")]
        public List<string> BindIdList { get; set; }

        /// <summary>
        /// 投放详情id
        /// </summary>
        [XmlElement("detail_id")]
        public string DetailId { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [XmlElement("gmt_end")]
        public string GmtEnd { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        [XmlElement("gmt_start")]
        public string GmtStart { get; set; }

        /// <summary>
        /// 投放详情名称，取创建运营投放的title，未传title取券名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 投放详情状态，INIT:下线状态，ON_LINE:上线状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
