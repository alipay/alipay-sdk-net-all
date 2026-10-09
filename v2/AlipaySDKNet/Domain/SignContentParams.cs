using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SignContentParams Data Structure.
    /// </summary>
    [Serializable]
    public class SignContentParams : AopObject
    {
        /// <summary>
        /// 商户侧用户唯一id，用于记录协议签约外部主体
        /// </summary>
        [XmlElement("out_user_id")]
        public string OutUserId { get; set; }
    }
}
