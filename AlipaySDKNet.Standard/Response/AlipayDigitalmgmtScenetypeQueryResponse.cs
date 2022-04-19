using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDigitalmgmtScenetypeQueryResponse.
    /// </summary>
    public class AlipayDigitalmgmtScenetypeQueryResponse : AopResponse
    {
        /// <summary>
        /// 场景类型信息列表
        /// </summary>
        [XmlElement("scene_type_list_result")]
        public SceneTypeListResult SceneTypeListResult { get; set; }
    }
}
