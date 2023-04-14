using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySocialBaseContentlibStandardcontentBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySocialBaseContentlibStandardcontentBatchqueryModel : AopObject
    {
        /// <summary>
        /// 指示是否返回内容详情,  默认为false false: 仅返回内容ID列表 true:返回 content_details
        /// </summary>
        [XmlElement("need_detail")]
        public bool NeedDetail { get; set; }

        /// <summary>
        /// 当页分页,默认为1
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 分页记录数，最大20,默认20
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 生活号+号ID，只有MCN机构为达人号ID查询内容才需要传入
        /// </summary>
        [XmlElement("public_id")]
        public string PublicId { get; set; }

        /// <summary>
        /// 内容状态，默认查询所有状态 0-审核中  1-发布成功  2-审核不通过  3-己删除
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
