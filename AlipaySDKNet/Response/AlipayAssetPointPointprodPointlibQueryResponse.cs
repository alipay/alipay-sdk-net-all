using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayAssetPointPointprodPointlibQueryResponse.
    /// </summary>
    public class AlipayAssetPointPointprodPointlibQueryResponse : AopResponse
    {
        /// <summary>
        /// 集分宝积分库查询结果，包含积分库ID，名称，余额等
        /// </summary>
        [XmlElement("result")]
        public PointLibResult Result { get; set; }
    }
}
