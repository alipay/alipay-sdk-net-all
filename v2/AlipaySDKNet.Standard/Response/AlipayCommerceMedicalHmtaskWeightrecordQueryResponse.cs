using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalHmtaskWeightrecordQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalHmtaskWeightrecordQueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("items")]
        [XmlArrayItem("weight_record_item")]
        public List<WeightRecordItem> Items { get; set; }

        /// <summary>
        /// 当前页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页条数
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 总记录条数
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
