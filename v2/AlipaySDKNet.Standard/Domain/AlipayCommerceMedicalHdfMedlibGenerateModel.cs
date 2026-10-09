using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalHdfMedlibGenerateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalHdfMedlibGenerateModel : AopObject
    {
        /// <summary>
        /// 入参数据
        /// </summary>
        [XmlElement("data")]
        public string Data { get; set; }
    }
}
