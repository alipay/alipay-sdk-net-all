using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// DatadigitalAicsDevinClueSyncResponse.
    /// </summary>
    public class DatadigitalAicsDevinClueSyncResponse : AopResponse
    {
        /// <summary>
        /// 同步线索业务数据后的返回数据ID
        /// </summary>
        [XmlElement("data_id")]
        public string DataId { get; set; }
    }
}
