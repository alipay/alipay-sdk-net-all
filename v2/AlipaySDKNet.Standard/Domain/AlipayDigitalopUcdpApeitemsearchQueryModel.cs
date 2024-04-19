using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDigitalopUcdpApeitemsearchQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDigitalopUcdpApeitemsearchQueryModel : AopObject
    {
        /// <summary>
        /// ape搜索的上下文
        /// </summary>
        [XmlElement("context")]
        public ApeSearchContext Context { get; set; }

        /// <summary>
        /// 加密的userid
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页的大小，取值范围是1~500。分页参数为空时默认返回最多500个item
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 商家在蚂蚁推荐引擎创建的项目id，调用前需要找蚂蚁技术获取。
        /// </summary>
        [XmlElement("project_id")]
        public string ProjectId { get; set; }

        /// <summary>
        /// 搜索词
        /// </summary>
        [XmlElement("query")]
        public string Query { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
