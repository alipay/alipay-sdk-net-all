using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceLogisticsVoicePlansnfailQueryResponse.
    /// </summary>
    public class AlipayCommerceLogisticsVoicePlansnfailQueryResponse : AopResponse
    {
        /// <summary>
        /// 当前页最大数据ID，用于翻页
        /// </summary>
        [XmlElement("cur_page_max_data_id")]
        public string CurPageMaxDataId { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("data_list")]
        [XmlArrayItem("logistics_sn_verify_fail_detail")]
        public List<LogisticsSnVerifyFailDetail> DataList { get; set; }

        /// <summary>
        /// 是否有更多数据
        /// </summary>
        [XmlElement("has_more")]
        public bool HasMore { get; set; }

        /// <summary>
        /// 是否正在保存中
        /// </summary>
        [XmlElement("saving")]
        public bool Saving { get; set; }
    }
}
