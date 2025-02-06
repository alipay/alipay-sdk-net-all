using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayIserviceCcmCrmClueModifyResponse.
    /// </summary>
    public class AlipayIserviceCcmCrmClueModifyResponse : AopResponse
    {
        /// <summary>
        /// 修改线索数据后的同步的数据ID
        /// </summary>
        [XmlElement("data_id")]
        public string DataId { get; set; }
    }
}
