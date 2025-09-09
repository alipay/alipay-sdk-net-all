using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MiniOrderAddressInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class MiniOrderAddressInfoDTO : AopObject
    {
        /// <summary>
        /// 详细地址信息
        /// </summary>
        [XmlElement("detailed_address")]
        public string DetailedAddress { get; set; }

        /// <summary>
        /// 标准城市区划代码，区维度的编码
        /// </summary>
        [XmlElement("division_code")]
        public string DivisionCode { get; set; }

        /// <summary>
        /// 联系人姓名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 联系人号码
        /// </summary>
        [XmlElement("tel_number")]
        public string TelNumber { get; set; }
    }
}
