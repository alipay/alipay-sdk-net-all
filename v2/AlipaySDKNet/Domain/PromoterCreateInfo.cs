using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PromoterCreateInfo Data Structure.
    /// </summary>
    [Serializable]
    public class PromoterCreateInfo : AopObject
    {
        /// <summary>
        /// 处理结果描述
        /// </summary>
        [XmlElement("msg")]
        public string Msg { get; set; }

        /// <summary>
        /// 处理结果,true:成功，false:失败
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
