using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossProdAntlescenterEsignresultQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossProdAntlescenterEsignresultQueryModel : AopObject
    {
        /// <summary>
        /// 系统来源名称
        /// </summary>
        [XmlElement("app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// 唯一业务标识号
        /// </summary>
        [XmlElement("business_unique_id")]
        public string BusinessUniqueId { get; set; }

        /// <summary>
        /// 发起电子签署成功后返回的流水号id
        /// </summary>
        [XmlElement("seal_request_id")]
        public string SealRequestId { get; set; }
    }
}
