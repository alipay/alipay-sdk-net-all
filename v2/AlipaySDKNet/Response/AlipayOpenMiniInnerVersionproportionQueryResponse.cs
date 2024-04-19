using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniInnerVersionproportionQueryResponse.
    /// </summary>
    public class AlipayOpenMiniInnerVersionproportionQueryResponse : AopResponse
    {
        /// <summary>
        /// 查询基础版本库的结果
        /// </summary>
        [XmlArray("appx_version_config_vos")]
        [XmlArrayItem("appx_version_config_vo")]
        public List<AppxVersionConfigVo> AppxVersionConfigVos { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 总数
        /// </summary>
        [XmlElement("total_number")]
        public string TotalNumber { get; set; }
    }
}
