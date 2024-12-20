using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalHdfMedlibGenerateResponse.
    /// </summary>
    public class AlipayCommerceMedicalHdfMedlibGenerateResponse : AopResponse
    {
        /// <summary>
        /// 返回结果消息体内的具体内容
        /// </summary>
        [XmlElement("data")]
        public HdfCompletionChunk Data { get; set; }

        /// <summary>
        /// 消息体返回的类型; 当event类型为 message 时，请解析 data以获取详细信息；当 event 类型为 error 时，请解析data 以获取错误信息；当 event 类型为 ping 时，仅用于请求保持，无需处理；当 event 类型为 end 时，表示所有内容已经完成返回，不会再有后续的包，调用方请关闭链接；
        /// </summary>
        [XmlElement("event")]
        public string Event { get; set; }

        /// <summary>
        /// 标注返回的流式结构序号
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }
    }
}
