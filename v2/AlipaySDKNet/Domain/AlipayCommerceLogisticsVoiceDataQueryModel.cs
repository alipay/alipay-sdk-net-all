using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceLogisticsVoiceDataQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceLogisticsVoiceDataQueryModel : AopObject
    {
        /// <summary>
        /// 格式yyyyMMdd，支持最近30天
        /// </summary>
        [XmlElement("biz_date")]
        public string BizDate { get; set; }

        /// <summary>
        /// 维度值
        /// </summary>
        [XmlElement("dim_key")]
        public string DimKey { get; set; }

        /// <summary>
        /// 维度类型
        /// </summary>
        [XmlElement("dim_type")]
        public string DimType { get; set; }

        /// <summary>
        /// 不传时默认20
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 深分页时上一面返回的cur_page_max_data_id的值.不传时从最小id开始查询
        /// </summary>
        [XmlElement("pre_page_max_data_id")]
        public string PrePageMaxDataId { get; set; }
    }
}
