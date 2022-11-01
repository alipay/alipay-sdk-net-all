using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenOperationOpenbizmockRzonegroovyQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenOperationOpenbizmockRzonegroovyQueryModel : AopObject
    {
        /// <summary>
        /// 测试
        /// </summary>
        [XmlElement("agreement_params")]
        public AgreementParams AgreementParams { get; set; }

        /// <summary>
        /// 测试
        /// </summary>
        [XmlElement("uid")]
        public string Uid { get; set; }
    }
}
