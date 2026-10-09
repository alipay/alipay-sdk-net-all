using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsSceneLogisticsInfoSyncResponse.
    /// </summary>
    public class AlipayInsSceneLogisticsInfoSyncResponse : AopResponse
    {
        /// <summary>
        /// 受理单号
        /// </summary>
        [XmlElement("application_no")]
        public string ApplicationNo { get; set; }
    }
}
