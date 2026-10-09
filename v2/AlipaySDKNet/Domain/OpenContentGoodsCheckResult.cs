using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenContentGoodsCheckResult Data Structure.
    /// </summary>
    [Serializable]
    public class OpenContentGoodsCheckResult : AopObject
    {
        /// <summary>
        /// 具体每项控货校验子项详情列表
        /// </summary>
        [XmlArray("sub_detail_list")]
        [XmlArrayItem("open_goods_check_detail")]
        public List<OpenGoodsCheckDetail> SubDetailList { get; set; }

        /// <summary>
        /// 所有控货结果汇总是否通过，true：控货通过，false：控货不通过
        /// </summary>
        [XmlElement("summary_result")]
        public bool SummaryResult { get; set; }
    }
}
