using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// StageCateInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class StageCateInfoVO : AopObject
    {
        /// <summary>
        /// 类目信息列表
        /// </summary>
        [XmlArray("cate_infos")]
        [XmlArrayItem("cate_info_v_o")]
        public List<CateInfoVO> CateInfos { get; set; }

        /// <summary>
        /// 学段编码
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 学段名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
