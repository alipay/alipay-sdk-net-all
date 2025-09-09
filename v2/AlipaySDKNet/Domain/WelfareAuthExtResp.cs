using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// WelfareAuthExtResp Data Structure.
    /// </summary>
    [Serializable]
    public class WelfareAuthExtResp : AopObject
    {
        /// <summary>
        /// 该参数用来标识用户来源，是供应商不同的场景传入对应的来源，蚂蚁EAP会根据此来判断员工是否在权益范围内
        /// </summary>
        [XmlElement("corp_group")]
        public string CorpGroup { get; set; }
    }
}
