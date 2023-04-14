using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataIotdataSearchlibraryBaiUploadModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataIotdataSearchlibraryBaiUploadModel : AopObject
    {
        /// <summary>
        /// 账户ID，账户粒度ID。
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 产品ID，[BANQUAN, PAIPAI]
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 商户ID，即平台用户ID。
        /// </summary>
        [XmlElement("company_id")]
        public string CompanyId { get; set; }

        /// <summary>
        /// 内容id
        /// </summary>
        [XmlElement("content_id")]
        public string ContentId { get; set; }

        /// <summary>
        /// 待检测内容的raw data，这期暂不使用
        /// </summary>
        [XmlElement("entity_data")]
        public string EntityData { get; set; }

        /// <summary>
        /// 待检测字段的描述信息，包括标题、描述或关键词，json格式字符串
        /// </summary>
        [XmlElement("entity_desc")]
        public string EntityDesc { get; set; }

        /// <summary>
        /// 内容hash值
        /// </summary>
        [XmlElement("entity_hash")]
        public string EntityHash { get; set; }

        /// <summary>
        /// 待检测内容类型，[TEXT, PICTURE, VIDEO, HTML]
        /// </summary>
        [XmlElement("entity_type")]
        public string EntityType { get; set; }

        /// <summary>
        /// 待检测内容oss url（后续可以扩展为非oss的文件url）
        /// </summary>
        [XmlElement("entity_url")]
        public string EntityUrl { get; set; }

        /// <summary>
        /// 媒体内容向量化的结果。
        /// </summary>
        [XmlElement("entity_vector")]
        public string EntityVector { get; set; }

        /// <summary>
        /// 扩展字段1
        /// </summary>
        [XmlElement("ex_1")]
        public string Ex1 { get; set; }

        /// <summary>
        /// 扩展字段2
        /// </summary>
        [XmlElement("ex_2")]
        public string Ex2 { get; set; }

        /// <summary>
        /// 扩展字段3
        /// </summary>
        [XmlElement("ex_3")]
        public string Ex3 { get; set; }

        /// <summary>
        /// 扩展字段4
        /// </summary>
        [XmlElement("ex_4")]
        public string Ex4 { get; set; }

        /// <summary>
        /// 扩展字段5
        /// </summary>
        [XmlElement("ex_5")]
        public string Ex5 { get; set; }

        /// <summary>
        /// 时间戳
        /// </summary>
        [XmlElement("time_stamp")]
        public string TimeStamp { get; set; }
    }
}
