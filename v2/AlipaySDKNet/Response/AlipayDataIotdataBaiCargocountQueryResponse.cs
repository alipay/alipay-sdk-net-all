using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataIotdataBaiCargocountQueryResponse.
    /// </summary>
    public class AlipayDataIotdataBaiCargocountQueryResponse : AopResponse
    {
        /// <summary>
        /// JSON字符串，包含盘点结果详情，如检测到每个货物的中心点坐标
        /// </summary>
        [XmlElement("storage_detail")]
        public string StorageDetail { get; set; }

        /// <summary>
        /// 算法盘点出的货物数量
        /// </summary>
        [XmlElement("storage_num")]
        public long StorageNum { get; set; }
    }
}
