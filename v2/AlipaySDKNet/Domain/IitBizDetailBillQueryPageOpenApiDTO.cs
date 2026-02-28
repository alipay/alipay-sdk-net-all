using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IitBizDetailBillQueryPageOpenApiDTO Data Structure.
    /// </summary>
    [Serializable]
    public class IitBizDetailBillQueryPageOpenApiDTO : AopObject
    {
        /// <summary>
        /// 批次号
        /// </summary>
        [XmlElement("batch_no")]
        public string BatchNo { get; set; }

        /// <summary>
        /// 一般是对应业务的销售产品码
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 业务场景码
        /// </summary>
        [XmlElement("biz_scene_code")]
        public string BizSceneCode { get; set; }

        /// <summary>
        /// 机构Id
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 页数
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 页条数
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 期间，月份
        /// </summary>
        [XmlElement("period")]
        public string Period { get; set; }
    }
}
