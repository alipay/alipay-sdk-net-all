using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenDeleteCreativeResponse Data Structure.
    /// </summary>
    [Serializable]
    public class OpenDeleteCreativeResponse : AopObject
    {
        /// <summary>
        /// 创意删除失败详情列表
        /// </summary>
        [XmlArray("creative_fail_detail_list")]
        [XmlArrayItem("creative_delete_fail_detail")]
        public List<CreativeDeleteFailDetail> CreativeFailDetailList { get; set; }

        /// <summary>
        /// 删除成功外部创意id集合
        /// </summary>
        [XmlArray("creative_outer_id_success_list")]
        [XmlArrayItem("string")]
        public List<string> CreativeOuterIdSuccessList { get; set; }
    }
}
