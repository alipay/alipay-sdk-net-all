using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LifeServiceUserInfo Data Structure.
    /// </summary>
    [Serializable]
    public class LifeServiceUserInfo : AopObject
    {
        /// <summary>
        /// 用于展示订单归属的手机号易于辨识
        /// </summary>
        [XmlElement("phone")]
        public string Phone { get; set; }
    }
}
