using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EpSpuSpecificInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EpSpuSpecificInfo : AopObject
    {
        /// <summary>
        /// 1688一级类目代码
        /// </summary>
        [XmlElement("cate_1_code_cbu")]
        public string Cate1CodeCbu { get; set; }

        /// <summary>
        /// 标准一级类目代码
        /// </summary>
        [XmlElement("cate_1_code_std")]
        public string Cate1CodeStd { get; set; }

        /// <summary>
        /// 1688一级类目名称
        /// </summary>
        [XmlElement("cate_1_name_cbu")]
        public string Cate1NameCbu { get; set; }

        /// <summary>
        /// 标准一级类目名称
        /// </summary>
        [XmlElement("cate_1_name_std")]
        public string Cate1NameStd { get; set; }

        /// <summary>
        /// 1688二级类目代码
        /// </summary>
        [XmlElement("cate_2_code_cbu")]
        public string Cate2CodeCbu { get; set; }

        /// <summary>
        /// 标准二级类目代码
        /// </summary>
        [XmlElement("cate_2_code_std")]
        public string Cate2CodeStd { get; set; }

        /// <summary>
        /// 1688二级类目名称
        /// </summary>
        [XmlElement("cate_2_name_cbu")]
        public string Cate2NameCbu { get; set; }

        /// <summary>
        /// 标准二级类目名称
        /// </summary>
        [XmlElement("cate_2_name_std")]
        public string Cate2NameStd { get; set; }

        /// <summary>
        /// 1688三级类目代码
        /// </summary>
        [XmlElement("cate_3_code_cbu")]
        public string Cate3CodeCbu { get; set; }

        /// <summary>
        /// 1688三级类目名称
        /// </summary>
        [XmlElement("cate_3_name_cbu")]
        public string Cate3NameCbu { get; set; }

        /// <summary>
        /// 置信度
        /// </summary>
        [XmlElement("confindence")]
        public string Confindence { get; set; }

        /// <summary>
        /// 产品ID(MD5）
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 产品最新记录日期（格式：yy-MM-dd）
        /// </summary>
        [XmlElement("item_mark_date")]
        public string ItemMarkDate { get; set; }

        /// <summary>
        /// 产品名称
        /// </summary>
        [XmlElement("item_name")]
        public string ItemName { get; set; }
    }
}
