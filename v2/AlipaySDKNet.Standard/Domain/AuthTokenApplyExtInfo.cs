using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AuthTokenApplyExtInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AuthTokenApplyExtInfo : AopObject
    {
        /// <summary>
        /// 车牌号
        /// </summary>
        [XmlElement("plate_no")]
        public string PlateNo { get; set; }
    }
}
