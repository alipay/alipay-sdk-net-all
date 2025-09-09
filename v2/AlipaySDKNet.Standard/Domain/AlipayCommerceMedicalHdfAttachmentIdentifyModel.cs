using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalHdfAttachmentIdentifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalHdfAttachmentIdentifyModel : AopObject
    {
        /// <summary>
        /// 入参数据内容
        /// </summary>
        [XmlElement("data")]
        public string Data { get; set; }
    }
}
