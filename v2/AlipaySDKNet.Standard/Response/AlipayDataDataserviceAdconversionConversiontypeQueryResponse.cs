using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataserviceAdconversionConversiontypeQueryResponse.
    /// </summary>
    public class AlipayDataDataserviceAdconversionConversiontypeQueryResponse : AopResponse
    {
        /// <summary>
        /// 资产基础信息列表
        /// </summary>
        [XmlArray("asset_detail_list")]
        [XmlArrayItem("asset_detail")]
        public List<AssetDetail> AssetDetailList { get; set; }
    }
}
