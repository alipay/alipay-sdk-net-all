using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataserviceAdDatasetSyncResponse.
    /// </summary>
    public class AlipayDataDataserviceAdDatasetSyncResponse : AopResponse
    {
        /// <summary>
        /// 成功同步数据集外部标志
        /// </summary>
        [XmlElement("data_id")]
        public string DataId { get; set; }
    }
}
