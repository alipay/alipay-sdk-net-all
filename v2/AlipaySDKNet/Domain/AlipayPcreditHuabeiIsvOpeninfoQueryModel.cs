using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayPcreditHuabeiIsvOpeninfoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPcreditHuabeiIsvOpeninfoQueryModel : AopObject
    {
        /// <summary>
        /// 一次请求的唯一性标识,调用时需要保证在非重试类请求中不重复.
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 二级商户唯一标识
        /// </summary>
        [XmlElement("smid")]
        public string Smid { get; set; }

        /// <summary>
        /// 店铺的唯一标识,可以不填写.
        /// </summary>
        [XmlElement("store_id")]
        public string StoreId { get; set; }
    }
}
