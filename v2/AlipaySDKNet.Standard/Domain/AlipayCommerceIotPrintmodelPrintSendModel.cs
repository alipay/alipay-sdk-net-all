using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceIotPrintmodelPrintSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceIotPrintmodelPrintSendModel : AopObject
    {
        /// <summary>
        /// 服务调用上下文
        /// </summary>
        [XmlElement("context")]
        public ServiceModelContext Context { get; set; }

        /// <summary>
        /// 打印服务调用内容
        /// </summary>
        [XmlElement("print_message")]
        public PrintMessageVO PrintMessage { get; set; }
    }
}
