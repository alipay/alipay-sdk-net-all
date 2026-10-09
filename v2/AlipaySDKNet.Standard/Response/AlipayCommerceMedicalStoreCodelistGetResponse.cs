using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalStoreCodelistGetResponse.
    /// </summary>
    public class AlipayCommerceMedicalStoreCodelistGetResponse : AopResponse
    {
        /// <summary>
        /// 门店编码数组
        /// </summary>
        [XmlArray("records")]
        [XmlArrayItem("string")]
        public List<string> Records { get; set; }

        /// <summary>
        /// 一共有多少个成功入驻的门店编码
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
