using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossBaseFrastressQuerybiztreeQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossBaseFrastressQuerybiztreeQueryModel : AopObject
    {
        /// <summary>
        /// 节点id
        /// </summary>
        [XmlElement("node_id")]
        public string NodeId { get; set; }

        /// <summary>
        /// 户id
        /// </summary>
        [XmlElement("tnt_inst_id")]
        public string TntInstId { get; set; }

        /// <summary>
        /// 树id
        /// </summary>
        [XmlElement("tree_id")]
        public string TreeId { get; set; }

        /// <summary>
        /// 用户id，可不传，传入会鉴权
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 不需要视图过滤可不传
        /// </summary>
        [XmlElement("view")]
        public string View { get; set; }
    }
}
