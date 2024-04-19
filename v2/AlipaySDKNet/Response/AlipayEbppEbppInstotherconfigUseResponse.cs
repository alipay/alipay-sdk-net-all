using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppEbppInstotherconfigUseResponse.
    /// </summary>
    public class AlipayEbppEbppInstotherconfigUseResponse : AopResponse
    {
        /// <summary>
        /// 当前页面
        /// </summary>
        [XmlElement("current_page")]
        public long CurrentPage { get; set; }

        /// <summary>
        /// 杂项配置数据
        /// </summary>
        [XmlArray("other_configs")]
        [XmlArrayItem("other_config_vo")]
        public List<OtherConfigVo> OtherConfigs { get; set; }

        /// <summary>
        /// 每页展示的数据的个数
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 总的数据大小
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }
    }
}
