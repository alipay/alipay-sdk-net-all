using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalHdfopenmqMessageSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalHdfopenmqMessageSendModel : AopObject
    {
        /// <summary>
        /// 好大夫变更消息体
        /// </summary>
        [XmlElement("hdfbody")]
        public string Hdfbody { get; set; }
    }
}
