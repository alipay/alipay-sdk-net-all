using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceIsresourceOpenapiTransferModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceIsresourceOpenapiTransferModel : AopObject
    {
        /// <summary>
        /// facade名称#方法名
        /// </summary>
        [XmlElement("action")]
        public string Action { get; set; }

        /// <summary>
        /// 接口参数
        /// </summary>
        [XmlElement("params")]
        public string Params { get; set; }
    }
}
