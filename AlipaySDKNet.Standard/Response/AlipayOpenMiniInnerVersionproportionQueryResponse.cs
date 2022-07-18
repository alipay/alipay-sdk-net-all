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
    }
}
