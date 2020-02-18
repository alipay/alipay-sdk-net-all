using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsSceneHealthActivitySyncResponse.
    /// </summary>
    public class AlipayInsSceneHealthActivitySyncResponse : AopResponse
    {
        /// <summary>
        /// 申请编号，成功返回原申请编号，失败为空
        /// </summary>
        [XmlElement("apply_no")]
        public string ApplyNo { get; set; }
    }
}
