using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataserviceYuebaoassetDetailSendResponse.
    /// </summary>
    public class AlipayDataDataserviceYuebaoassetDetailSendResponse : AopResponse
    {
        /// <summary>
        /// yeb_asset_data_num:本次录入数据条数。  可以根据该字段获取本次录入的数据条数，判断是否所有数据都已经落地。
        /// </summary>
        [XmlElement("yeb_asset_data_num")]
        public long YebAssetDataNum { get; set; }
    }
}
