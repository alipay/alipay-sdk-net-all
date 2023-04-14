using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniWidgetDataSyncResponse.
    /// </summary>
    public class AlipayOpenMiniWidgetDataSyncResponse : AopResponse
    {
        /// <summary>
        /// 同步接口生成的唯一标识，用于查询提交数据的审核状态
        /// </summary>
        [XmlElement("commit_id")]
        public string CommitId { get; set; }
    }
}
