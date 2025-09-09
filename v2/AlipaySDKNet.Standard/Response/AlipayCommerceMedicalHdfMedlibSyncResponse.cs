using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalHdfMedlibSyncResponse.
    /// </summary>
    public class AlipayCommerceMedicalHdfMedlibSyncResponse : AopResponse
    {
        /// <summary>
        /// 接口返回数据
        /// </summary>
        [XmlElement("data")]
        public string Data { get; set; }
    }
}
