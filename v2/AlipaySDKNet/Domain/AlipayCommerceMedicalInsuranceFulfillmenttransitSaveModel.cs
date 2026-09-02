using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalInsuranceFulfillmenttransitSaveModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalInsuranceFulfillmenttransitSaveModel : AopObject
    {
        /// <summary>
        /// 渠道
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("out_unique_biz_no_list")]
        [XmlArrayItem("string")]
        public List<string> OutUniqueBizNoList { get; set; }

        /// <summary>
        /// 产品编号
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 产品名称
        /// </summary>
        [XmlElement("product_name")]
        public string ProductName { get; set; }

        /// <summary>
        /// 服务失效时间
        /// </summary>
        [XmlElement("valid_end_time")]
        public string ValidEndTime { get; set; }

        /// <summary>
        /// 服务生效时间
        /// </summary>
        [XmlElement("valid_start_time")]
        public string ValidStartTime { get; set; }
    }
}
