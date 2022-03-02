using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenOperationIspTestUseModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenOperationIspTestUseModel : AopObject
    {
        /// <summary>
        /// 测试输入app_id
        /// </summary>
        [XmlElement("app")]
        public string App { get; set; }

        /// <summary>
        /// 测试参数
        /// </summary>
        [XmlElement("input")]
        public bool Input { get; set; }
    }
}
