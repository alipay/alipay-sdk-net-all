using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenApiSpecifiedChannelParamsPojo Data Structure.
    /// </summary>
    [Serializable]
    public class OpenApiSpecifiedChannelParamsPojo : AopObject
    {
        /// <summary>
        /// 资产类型编码，具体传参值请联系技术进行分配。
        /// </summary>
        [XmlElement("asset_type_code")]
        public string AssetTypeCode { get; set; }

        /// <summary>
        /// 机构描述
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }
    }
}
