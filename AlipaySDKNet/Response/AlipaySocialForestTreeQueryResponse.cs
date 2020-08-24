using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySocialForestTreeQueryResponse.
    /// </summary>
    public class AlipaySocialForestTreeQueryResponse : AopResponse
    {
        /// <summary>
        /// 森林开通状态： NON_OPEN：未开通；【种树记录列表为空list】 OPEN：已开通； CLOSED：已关闭；
        /// </summary>
        [XmlElement("forest_status")]
        public string ForestStatus { get; set; }

        /// <summary>
        /// 数据格式为List<TreeData>，按树种、是否合种分类统计后得到用户种植树信息数据列表
        /// </summary>
        [XmlArray("tree_datas")]
        [XmlArrayItem("tree_data")]
        public List<TreeData> TreeDatas { get; set; }

        /// <summary>
        /// 种树详细信息
        /// </summary>
        [XmlArray("tree_detail_data")]
        [XmlArrayItem("tree_detail_data")]
        public List<TreeDetailData> TreeDetailData { get; set; }
    }
}
