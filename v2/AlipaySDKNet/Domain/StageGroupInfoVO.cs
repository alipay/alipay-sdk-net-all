using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// StageGroupInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class StageGroupInfoVO : AopObject
    {
        /// <summary>
        /// 学段分组名称
        /// </summary>
        [XmlElement("group_name")]
        public string GroupName { get; set; }

        /// <summary>
        /// 学段类目信息列表
        /// </summary>
        [XmlArray("stage_cate_infos")]
        [XmlArrayItem("stage_cate_info_v_o")]
        public List<StageCateInfoVO> StageCateInfos { get; set; }
    }
}
