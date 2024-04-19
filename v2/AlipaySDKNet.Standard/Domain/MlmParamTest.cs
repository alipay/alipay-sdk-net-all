using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MlmParamTest Data Structure.
    /// </summary>
    [Serializable]
    public class MlmParamTest : AopObject
    {
        /// <summary>
        /// 参数
        /// </summary>
        [XmlElement("param_mlm_a")]
        public string ParamMlmA { get; set; }

        /// <summary>
        /// 描述number
        /// </summary>
        [XmlElement("param_mlm_b")]
        public long ParamMlmB { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlElement("param_mlm_c")]
        public bool ParamMlmC { get; set; }

        /// <summary>
        /// date描述
        /// </summary>
        [XmlElement("param_mlm_d")]
        public string ParamMlmD { get; set; }

        /// <summary>
        /// price描述
        /// </summary>
        [XmlElement("param_mlm_e")]
        public string ParamMlmE { get; set; }
    }
}
