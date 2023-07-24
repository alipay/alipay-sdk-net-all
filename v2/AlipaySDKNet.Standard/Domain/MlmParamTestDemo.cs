using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MlmParamTestDemo Data Structure.
    /// </summary>
    [Serializable]
    public class MlmParamTestDemo : AopObject
    {
        /// <summary>
        /// 基础描述
        /// </summary>
        [XmlElement("param_a")]
        public string ParamA { get; set; }

        /// <summary>
        /// 基础描述
        /// </summary>
        [XmlElement("param_a_openid")]
        public string ParamAOpenid { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("param_complex")]
        public MlmParamTest ParamComplex { get; set; }
    }
}
