using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OrderChangeInfoExtIstd Data Structure.
    /// </summary>
    [Serializable]
    public class OrderChangeInfoExtIstd : AopObject
    {
        /// <summary>
        /// 新增可选参数支持通过通知接口向商户同步“揽收/投递照片”链接
        /// </summary>
        [XmlArray("work_pic_link")]
        [XmlArrayItem("string")]
        public List<string> WorkPicLink { get; set; }
    }
}
