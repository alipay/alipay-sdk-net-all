using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppOpenidApplyorderUploadModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppOpenidApplyorderUploadModel : AopObject
    {
        /// <summary>
        /// 工单唯一标识
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 用户ID列表
        /// </summary>
        [XmlArray("user_id_list")]
        [XmlArrayItem("string")]
        public List<string> UserIdList { get; set; }
    }
}
