using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayIserviceAnthotlinemngRecordingQueryResponse.
    /// </summary>
    public class AlipayIserviceAnthotlinemngRecordingQueryResponse : AopResponse
    {
        /// <summary>
        /// 录音文件详情列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("recording")]
        public List<Recording> List { get; set; }
    }
}
