using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalImInfoSyncResponse.
    /// </summary>
    public class AlipayCommerceMedicalImInfoSyncResponse : AopResponse
    {
        /// <summary>
        /// 结果数据 true，false
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
