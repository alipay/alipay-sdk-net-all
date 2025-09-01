using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayContentCommercialCollectioncontentInfoDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayContentCommercialCollectioncontentInfoDeleteModel : AopObject
    {
        /// <summary>
        /// 合集ID，对应内容id关联的合集/短剧ID,来源于内容生态生成的ID，生产规则为日期+类型+版本号，该合集ID通过调用内容发布接口时自动生成
        /// </summary>
        [XmlElement("collection_id")]
        public string CollectionId { get; set; }

        /// <summary>
        /// 短视频内容id
        /// </summary>
        [XmlElement("content_id")]
        public string ContentId { get; set; }

        /// <summary>
        /// 请求类型：1: 新增短素材 2 编辑短素材 3 删除短素材 4 编辑合集内容
        /// </summary>
        [XmlElement("request_type")]
        public string RequestType { get; set; }
    }
}
