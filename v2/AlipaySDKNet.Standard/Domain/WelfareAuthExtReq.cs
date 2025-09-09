using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// WelfareAuthExtReq Data Structure.
    /// </summary>
    [Serializable]
    public class WelfareAuthExtReq : AopObject
    {
        /// <summary>
        /// 该参数用来标识用户来源，是供应商不同的场景传入对应的来源，蚂蚁EAP会根据此来判断员工是否在权益范围内
        /// </summary>
        [XmlElement("from_channel")]
        public string FromChannel { get; set; }
    }
}
