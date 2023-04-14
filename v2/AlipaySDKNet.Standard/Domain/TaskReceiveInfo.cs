using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TaskReceiveInfo Data Structure.
    /// </summary>
    [Serializable]
    public class TaskReceiveInfo : AopObject
    {
        /// <summary>
        /// 结果描述
        /// </summary>
        [XmlElement("msg")]
        public string Msg { get; set; }

        /// <summary>
        /// 任务领取结果,true:成功，false:失败
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
