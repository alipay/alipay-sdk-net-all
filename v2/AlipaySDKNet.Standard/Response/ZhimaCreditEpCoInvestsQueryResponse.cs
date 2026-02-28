using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpCoInvestsQueryResponse.
    /// </summary>
    public class ZhimaCreditEpCoInvestsQueryResponse : AopResponse
    {
        /// <summary>
        /// 数据集
        /// </summary>
        [XmlElement("data")]
        public EpCoInvestDataInfo Data { get; set; }

        /// <summary>
        /// 查得标记
        /// </summary>
        [XmlElement("data_found")]
        public bool DataFound { get; set; }
    }
}
