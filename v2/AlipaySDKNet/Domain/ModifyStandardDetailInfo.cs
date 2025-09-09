using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ModifyStandardDetailInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ModifyStandardDetailInfo : AopObject
    {
        /// <summary>
        /// 新增的使用规则列表
        /// </summary>
        [XmlArray("add_standard_list")]
        [XmlArrayItem("standard_info")]
        public List<StandardInfo> AddStandardList { get; set; }

        /// <summary>
        /// 待删除的使用规则id列表
        /// </summary>
        [XmlArray("delete_standard_id_list")]
        [XmlArrayItem("string")]
        public List<string> DeleteStandardIdList { get; set; }

        /// <summary>
        /// 待修改的使用规则信息列表
        /// </summary>
        [XmlArray("modify_standard_list")]
        [XmlArrayItem("modify_standard_info")]
        public List<ModifyStandardInfo> ModifyStandardList { get; set; }
    }
}
