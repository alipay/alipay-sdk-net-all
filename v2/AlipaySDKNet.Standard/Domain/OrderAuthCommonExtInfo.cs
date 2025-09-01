using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OrderAuthCommonExtInfo Data Structure.
    /// </summary>
    [Serializable]
    public class OrderAuthCommonExtInfo : AopObject
    {
        /// <summary>
        /// 车牌号
        /// </summary>
        [XmlElement("plate_no")]
        public string PlateNo { get; set; }

        /// <summary>
        /// 请求来源
        /// </summary>
        [XmlElement("request_channel")]
        public string RequestChannel { get; set; }
    }
}
