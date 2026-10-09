using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsSceneInsserviceprodLightserprogressSyncResponse.
    /// </summary>
    public class AlipayInsSceneInsserviceprodLightserprogressSyncResponse : AopResponse
    {
        /// <summary>
        /// 蚂蚁进度明细编号(业务主键)
        /// </summary>
        [XmlElement("progress_no")]
        public string ProgressNo { get; set; }
    }
}
