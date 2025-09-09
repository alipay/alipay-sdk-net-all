using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudpromoMallDivisionQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudpromoMallDivisionQueryModel : AopObject
    {
        /// <summary>
        /// 地区编码
        /// </summary>
        [XmlElement("division_code")]
        public string DivisionCode { get; set; }
    }
}
