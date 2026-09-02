using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AdConversionJoinWindow Data Structure.
    /// </summary>
    [Serializable]
    public class AdConversionJoinWindow : AopObject
    {
        /// <summary>
        /// ONE_DAY("1d", "1天"), THREE_DAY("3d", "3天"), SEVEN_DAY("7d", "7天"), FIFTEEN_DAY("15d", "15天");
        /// </summary>
        [XmlElement("join_window_code")]
        public string JoinWindowCode { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [XmlElement("join_window_name")]
        public string JoinWindowName { get; set; }
    }
}
