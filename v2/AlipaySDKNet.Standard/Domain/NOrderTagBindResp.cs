using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// NOrderTagBindResp Data Structure.
    /// </summary>
    [Serializable]
    public class NOrderTagBindResp : AopObject
    {
        /// <summary>
        /// 服务商调用接口绑定点位和物料关系时的现场作业图片
        /// </summary>
        [XmlArray("bind_pic")]
        [XmlArrayItem("string")]
        public List<string> BindPic { get; set; }

        /// <summary>
        /// 需要绑定点位的碰一下链接
        /// </summary>
        [XmlArray("nfc_url")]
        [XmlArrayItem("string")]
        public List<string> NfcUrl { get; set; }
    }
}
