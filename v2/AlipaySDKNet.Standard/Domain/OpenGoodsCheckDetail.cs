using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenGoodsCheckDetail Data Structure.
    /// </summary>
    [Serializable]
    public class OpenGoodsCheckDetail : AopObject
    {
        /// <summary>
        /// 控货子项的校验结果，true：通过，false：不通过
        /// </summary>
        [XmlElement("check_result")]
        public bool CheckResult { get; set; }

        /// <summary>
        /// 校验code，唯一标识一项控货校验规则
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 控货文案
        /// </summary>
        [XmlElement("detail_text")]
        public string DetailText { get; set; }
    }
}
