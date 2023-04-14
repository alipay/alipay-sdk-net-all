using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SearchBaseOrderCreateApiRequest Data Structure.
    /// </summary>
    [Serializable]
    public class SearchBaseOrderCreateApiRequest : AopObject
    {
        /// <summary>
        /// 搜索直达类型 BASE：基础信息，只支持基础信息工单提报
        /// </summary>
        [XmlElement("access_type")]
        public string AccessType { get; set; }

        /// <summary>
        /// 小程序Id
        /// </summary>
        [XmlElement("appid")]
        public string Appid { get; set; }

        /// <summary>
        /// 基础信息申请单提报详情
        /// </summary>
        [XmlElement("base_items")]
        public SearchBaseItems BaseItems { get; set; }

        /// <summary>
        /// 服务描述
        /// </summary>
        [XmlElement("descprise")]
        public string Descprise { get; set; }

        /// <summary>
        /// 是否为草稿态
        /// </summary>
        [XmlElement("is_draft")]
        public bool IsDraft { get; set; }

        /// <summary>
        /// 申请单id，仅仅驳回或修改是传入
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 服务的类型 SP_MINI_APP 小程序 SP_PUBLIC_APP 生活号
        /// </summary>
        [XmlElement("spec_code")]
        public string SpecCode { get; set; }
    }
}
