using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GrandsecurityBizrisksFactCheckModel Data Structure.
    /// </summary>
    [Serializable]
    public class GrandsecurityBizrisksFactCheckModel : AopObject
    {
        /// <summary>
        /// 用户输入的谣言/疑问文本，必填，最大 5000 字符
        /// </summary>
        [XmlElement("query")]
        public string Query { get; set; }
    }
}
