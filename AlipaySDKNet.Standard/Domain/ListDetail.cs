using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ListDetail Data Structure.
    /// </summary>
    [Serializable]
    public class ListDetail : AopObject
    {
        /// <summary>
        /// 额外参数，比如养殖规模、品种等
        /// </summary>
        [XmlElement("extra_data")]
        public string ExtraData { get; set; }

        /// <summary>
        /// 身份证号
        /// </summary>
        [XmlElement("id_card")]
        public string IdCard { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [XmlElement("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [XmlElement("user_name")]
        public string UserName { get; set; }
    }
}
