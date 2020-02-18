using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundTransBatchCreatesinglebatchResponse.
    /// </summary>
    public class AlipayFundTransBatchCreatesinglebatchResponse : AopResponse
    {
        /// <summary>
        /// 所创建成功后的批次号
        /// </summary>
        [XmlElement("batch_no")]
        public string BatchNo { get; set; }

        /// <summary>
        /// 调用方传入的ext_param，透传回去
        /// </summary>
        [XmlElement("ext_param")]
        public string ExtParam { get; set; }

        /// <summary>
        /// token，每个批次对应一个token，每次调用方进行查询的时候都要使用批次号和token进行组合查询
        /// </summary>
        [XmlElement("token")]
        public string Token { get; set; }
    }
}
